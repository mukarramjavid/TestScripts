using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestScriptsProject.Utilities;

namespace TestScriptsProject
{
    [Binding]
    public sealed class Hooks : BrowserHelper
    {
        [BeforeScenario]
        public async Task FirstBeforeScenario()
        {
            await Init();
        }

        [AfterScenario]
        public async Task AfterScenario()
        {
            await _browser.CloseAsync();
        }
    }
}
