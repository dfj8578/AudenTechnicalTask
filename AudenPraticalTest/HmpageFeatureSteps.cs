using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support;
using NUnit.Framework;


namespace AudenPraticalTest
{
    [Binding]

    class HmpageFeatureSteps
    {
        IWebDriver driver;
        



        [Given(@"I am on Auden homepage and select Loan Amount and Repayment day")]
        public void GivenIAmOnAudenHomepageAndSelectLoanAmountAndRepaymentDay()
        {

          

            homepage hmPage = new homepage();
            hmPage.ClickandMoveSelectedSliders();
            hmPage.SelectRepaymentDate();




        }

        

        [Then(@"i should see the First repayment date text as '(.*)'")]
        public void ThenIShouldSeeTheFirstRepaymentDateTextAs(string text)
        {


            homepage hmPage = new homepage();
            hmPage.Check_Repayment_Date(text);
        }


        [Then(@"i should see the The min as (.*) and Max as (.*)")]
        public void ThenIShouldSeeTheTheMinAsAndMaxAs(int min, int max)
        {
          //  homepage hmpage = new homepage();
          //  hmpage.CheckMinandMaxAmount(min);

           
        }


        [Then(@"i should see the The minandmax amount'")]
        public void ThenIShouldSeeTheTheMinandmaxAmount()
        {
          //  homepage hmpage = new homepage();
          //  hmpage.CheckMinandMaxAmount("200, 500");

           
        }

        [Then(@"The selected slider amount is Loan amount")]
        public void ThenTheSelectedSliderAmountIsLoanAmount()
        {
            homepage hmpage = new homepage();
            hmpage.CheckSliderAmountasLoanAmount("£450");
        }


     

       
            

       







    }

}
