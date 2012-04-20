﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.7.1.0
//      SpecFlow Generator Version:1.7.0.0
//      Runtime Version:4.0.30319.17379
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace TechTalk.SpecFlow.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.7.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Step definitions can be matched based on the method name (without Regex)")]
    public partial class StepDefinitionsCanBeMatchedBasedOnTheMethodNameWithoutRegexFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "StepDefinitionsWithoutRegex.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Step definitions can be matched based on the method name (without Regex)", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Parameterless steps")]
        public virtual void ParameterlessSteps()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Parameterless steps", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 4
 testRunner.Given("a scenario \'Simple Scenario\' as", "When I do something", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 8
 testRunner.And("the following step definitions", "[When]\r\npublic void When_I_do_something()\r\n{}", ((TechTalk.SpecFlow.Table)(null)));
#line 14
 testRunner.When("I execute the tests");
#line 15
 testRunner.Then("the binding method \'When_I_do_something\' is executed");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void StepsWithParameters(string @case, string parameter, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Steps with parameters", exampleTags);
#line 17
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 18
 testRunner.Given("a scenario \'Simple Scenario\' as", string.Format("When {0} does something", parameter), ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 22
 testRunner.And("the following step definitions", "[When]\r\npublic void When_WHO_does_something(string who)\r\n{\r\n\tif (who != \"Joe\") th" +
                    "row new Exception(\"invalid parameter: \" + who);\r\n}", ((TechTalk.SpecFlow.Table)(null)));
#line 30
 testRunner.When("I execute the tests");
#line 31
 testRunner.Then("the binding method \'When_WHO_does_something\' is executed");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Steps with parameters")]
        public virtual void StepsWithParameters_Simple()
        {
            this.StepsWithParameters("simple", "Joe", ((string[])(null)));
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Steps with parameters")]
        public virtual void StepsWithParameters_Quoted()
        {
            this.StepsWithParameters("quoted", "\"Joe\"", ((string[])(null)));
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Steps with parameters")]
        public virtual void StepsWithParameters_Apostrophed()
        {
            this.StepsWithParameters("apostrophed", "\'Joe\'", ((string[])(null)));
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Steps with parameters referred by index")]
        public virtual void StepsWithParametersReferredByIndex()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Steps with parameters referred by index", ((string[])(null)));
#line 39
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 40
 testRunner.Given("a scenario \'Simple Scenario\' as", "When Joe does something with:", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 44
 testRunner.And("the following step definitions", "[When]\r\npublic void When_P0_does_P1_with(string who, string what)\r\n{\r\n}", ((TechTalk.SpecFlow.Table)(null)));
#line 51
 testRunner.When("I execute the tests");
#line 52
 testRunner.Then("the binding method \'When_P0_does_P1_with\' is executed");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Steps with multiple parameters and punctuation")]
        public virtual void StepsWithMultipleParametersAndPunctuation()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Steps with multiple parameters and punctuation", ((string[])(null)));
#line 55
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 56
 testRunner.Given("a scenario \'Simple Scenario\' as", "When Joe does - something with:\r\n| table |", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 61
 testRunner.And("the following step definitions", "[When]\r\npublic void When_WHO_does_WHAT_with(string who, string what, Table table)" +
                    "\r\n{\r\n\tif (what != \"something\") throw new Exception(\"invalid parameter: \" + what)" +
                    ";\r\n}", ((TechTalk.SpecFlow.Table)(null)));
#line 69
 testRunner.When("I execute the tests");
#line 70
 testRunner.Then("the binding method \'When_WHO_does_WHAT_with\' is executed");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Keyword prefix can be omitted")]
        public virtual void KeywordPrefixCanBeOmitted()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Keyword prefix can be omitted", ((string[])(null)));
#line 73
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 74
 testRunner.Given("a scenario \'Simple Scenario\' as", "When I do something", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 78
 testRunner.And("the following step definitions", "[When] public void I_do_something()\r\n{}", ((TechTalk.SpecFlow.Table)(null)));
#line 83
 testRunner.When("I execute the tests");
#line 84
 testRunner.Then("the binding method \'I_do_something\' is executed");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void SupportsAllAttributes(string attribute, string step, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Supports all attributes", exampleTags);
#line 87
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 88
 testRunner.Given("a scenario \'Simple Scenario\' as", string.Format("{0} I do something", step), ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 92
 testRunner.And("the following step definitions", string.Format("[{0}] public void I_do_something()\r\n{{}}", attribute), ((TechTalk.SpecFlow.Table)(null)));
#line 97
 testRunner.When("I execute the tests");
#line 98
 testRunner.Then("the binding method \'I_do_something\' is executed");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Supports all attributes")]
        public virtual void SupportsAllAttributes_Given()
        {
            this.SupportsAllAttributes("Given", "Given", ((string[])(null)));
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Supports all attributes")]
        public virtual void SupportsAllAttributes_When()
        {
            this.SupportsAllAttributes("When", "When", ((string[])(null)));
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Supports all attributes")]
        public virtual void SupportsAllAttributes_Then()
        {
            this.SupportsAllAttributes("Then", "Then", ((string[])(null)));
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Supports all attributes")]
        public virtual void SupportsAllAttributes_StepDefinition()
        {
            this.SupportsAllAttributes("StepDefinition", "Given", ((string[])(null)));
        }
        
        public virtual void PascalCaseMethods(string @case, string method, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Pascal case methods", exampleTags);
#line 107
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 108
 testRunner.Given("a scenario \'Simple Scenario\' as", "When I do something really important", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 112
 testRunner.And("the following step definitions", string.Format("[When]\r\npublic void {0}(string howMuch)\r\n{{}}", method), ((TechTalk.SpecFlow.Table)(null)));
#line 118
 testRunner.When("I execute the tests");
#line 119
 testRunner.Then(string.Format("the binding method \'{0}\' is executed", method));
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Pascal case methods")]
        public virtual void PascalCaseMethods_EmbeddedParam()
        {
            this.PascalCaseMethods("embedded param", "WhenIDoSomethingHOWMUCHImportant", ((string[])(null)));
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Pascal case methods")]
        public virtual void PascalCaseMethods_ParamWithUnderscore()
        {
            this.PascalCaseMethods("param with underscore", "WhenIDoSomething_HOWMUCH_Important", ((string[])(null)));
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Pascal case methods")]
        public virtual void PascalCaseMethods_MixedUnderscores()
        {
            this.PascalCaseMethods("mixed underscores", "WhenI_Do_SomethingHOWMUCHImportant", ((string[])(null)));
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Underscore in parameter name")]
        public virtual void UnderscoreInParameterName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Underscore in parameter name", ((string[])(null)));
#line 127
this.ScenarioSetup(scenarioInfo);
#line hidden
#line 128
 testRunner.Given("a scenario \'Simple Scenario\' as", "When Joe does something", ((TechTalk.SpecFlow.Table)(null)));
#line hidden
#line 132
 testRunner.And("the following step definitions", "[When]\r\npublic void When_W_H_O_does_something(string w_h_o)\r\n{\r\n}", ((TechTalk.SpecFlow.Table)(null)));
#line 139
 testRunner.When("I execute the tests");
#line 140
 testRunner.Then("the binding method \'When_W_H_O_does_something\' is executed");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#endregion
