﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecRun
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Scenarios With Special Characters", Description="Here we demonstrate usage of special characters in scenario names", SourceFile="ScenariosWithSpecialCharacters.feature", SourceLine=0)]
    public partial class ScenariosWithSpecialCharactersFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ScenariosWithSpecialCharacters.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Scenarios With Special Characters", "Here we demonstrate usage of special characters in scenario names", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 4
#line 5
  testRunner.Given("the calculator has clean memory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("This is a scenario with parentheses, hyphen and comma (10-20, 30-40)", SourceLine=6)]
        public virtual void ThisIsAScenarioWithParenthesesHyphenAndComma10_2030_40()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("This is a scenario with parentheses, hyphen and comma (10-20, 30-40)", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 8
  testRunner.Given("I have entered 50 into the calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
  testRunner.And("I have entered 70 into the calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
  testRunner.When("I press add", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
  testRunner.Then("the result should be 120 on the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void ThisIsAScenarioOutlineWithParenthesesHyphenAndComma10_2030_40(string result, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("This is a scenario outline with parentheses, hyphen and comma (10-20, 30-40)", exampleTags);
#line 14
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 15
  testRunner.Then(string.Format("the scenario will \'{0}\'", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("This is a scenario outline with parentheses, hyphen and comma (10-20, 30-40), pas" +
            "s_1", SourceLine=18)]
        public virtual void ThisIsAScenarioOutlineWithParenthesesHyphenAndComma10_2030_40_Pass_1()
        {
            this.ThisIsAScenarioOutlineWithParenthesesHyphenAndComma10_2030_40("pass_1", ((string[])(null)));
        }
        
        public virtual void ThisScenarioContainsExamplesWithRegex_SpecialCharacters(string regex, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("This scenario contains examples with Regex-special characters", exampleTags);
#line 21
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 22
  testRunner.When(string.Format("I have special characters for regexes in the value, for example a \'{0}\'", regex), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
  testRunner.Then("the scenario will \'PASS\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("This scenario contains examples with Regex-special characters, Variant 0", SourceLine=26)]
        public virtual void ThisScenarioContainsExamplesWithRegex_SpecialCharacters_Variant0()
        {
            this.ThisScenarioContainsExamplesWithRegex_SpecialCharacters("**", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("This scenario contains examples with Regex-special characters, Variant 1", SourceLine=27)]
        public virtual void ThisScenarioContainsExamplesWithRegex_SpecialCharacters_Variant1()
        {
            this.ThisScenarioContainsExamplesWithRegex_SpecialCharacters("++", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("This scenario contains examples with Regex-special characters, Variant 2", SourceLine=28)]
        public virtual void ThisScenarioContainsExamplesWithRegex_SpecialCharacters_Variant2()
        {
            this.ThisScenarioContainsExamplesWithRegex_SpecialCharacters(".*", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("This scenario contains examples with Regex-special characters, Variant 3", SourceLine=29)]
        public virtual void ThisScenarioContainsExamplesWithRegex_SpecialCharacters_Variant3()
        {
            this.ThisScenarioContainsExamplesWithRegex_SpecialCharacters("[]", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("This scenario contains examples with Regex-special characters, Variant 4", SourceLine=30)]
        public virtual void ThisScenarioContainsExamplesWithRegex_SpecialCharacters_Variant4()
        {
            this.ThisScenarioContainsExamplesWithRegex_SpecialCharacters("{}", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("This scenario contains examples with Regex-special characters, Variant 5", SourceLine=31)]
        public virtual void ThisScenarioContainsExamplesWithRegex_SpecialCharacters_Variant5()
        {
            this.ThisScenarioContainsExamplesWithRegex_SpecialCharacters("()", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("This scenario contains examples with Regex-special characters, Variant 6", SourceLine=32)]
        public virtual void ThisScenarioContainsExamplesWithRegex_SpecialCharacters_Variant6()
        {
            this.ThisScenarioContainsExamplesWithRegex_SpecialCharacters("^.*(?<foo>BAR)\\s[^0-9]{3,4}A+$", ((string[])(null)));
        }
        
        public virtual void ThisIsAScenarioOutlineWithGermanUmlautsAouBAOU(string result, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("This is a scenario outline with german umlauts äöüß ÄÖÜ", exampleTags);
#line 35
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 36
  testRunner.Then(string.Format("the scenario will \'{0}\'", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("This is a scenario outline with german umlauts äöüß ÄÖÜ, pass_1", SourceLine=39)]
        public virtual void ThisIsAScenarioOutlineWithGermanUmlautsAouBAOU_Pass_1()
        {
            this.ThisIsAScenarioOutlineWithGermanUmlautsAouBAOU("pass_1", ((string[])(null)));
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("This is a scenario with danish characters æøå ÆØÅ", SourceLine=49)]
        public virtual void ThisIsAScenarioWithDanishCharactersAEoaAEOA()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("This is a scenario with danish characters æøå ÆØÅ", ((string[])(null)));
#line 50
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 51
  testRunner.Then("the step with danish characters like æøå and ÆØÅ shall pass", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
