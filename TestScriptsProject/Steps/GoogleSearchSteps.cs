using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestScriptsProject.Utilities;

namespace TestScriptsProject.Steps
{
    [Binding]
    public class GoogleSearchSteps : BrowserHelper
    {
      
        [Given(@"I am on Google.com")]
        public async Task GivenIAmOnGoogleCom()
        {
            await _page.GoToAsync("https://www.google.com/");
        }

        [When(@"Click on Constent button")]
        public async Task ClickOnConsentButton()
        {
            await _page.ClickAsync("#L2AGLb");
        }

        [When(@"I enter ""(.*)"" in the search bar")]
        public async Task WhenIEnterTextInTheSearchBar(string searchText)
        {
            await _page.TypeAsync("textarea[name=q]", searchText);

        }

        [When(@"I press Enter")]
        public async Task WhenIPressEnter()
        {
            await _page.Keyboard.PressAsync("Enter");
            await _page.WaitForSelectorAsync("#search");
        }

        [Then(@"the search results should contain the text ""(.*)""")]
        public async Task ThenTheSearchResultsShouldContainTheText(string expectedText)
        {
            var html = await _page.GetContentAsync();
            Assert.IsTrue(html.Contains(expectedText));
        }
    }
}
