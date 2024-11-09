Feature: GoogleSearch

A short summary of the feature

Scenario: Search for PuppeteerSharp on Google
    Given I am on Google.com
    When Click on Constent button
    When I enter "PuppeteerSharp" in the search bar
    And I press Enter
    Then the search results should contain the text "PuppeteerSharp"
