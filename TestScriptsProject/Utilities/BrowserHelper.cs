using PuppeteerSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScriptsProject.Utilities
{
    public class BrowserHelper
    {
        public static IBrowser _browser;
        public static IPage _page;
        public async Task Init()
        {
            var revision = await new BrowserFetcher(SupportedBrowser.Chromium).DownloadAsync();

            _browser = await Puppeteer.LaunchAsync(new LaunchOptions()
            {
                Headless = false,
                ExecutablePath = revision.GetExecutablePath()
            });

            _page = await _browser.NewPageAsync();
        }
    }
}
