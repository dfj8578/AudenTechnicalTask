using OpenQA.Selenium.Support.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AudenPraticalTest
{
    public class homepage


    {
        public homepage()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
          
        }

        [FindsBy(How = How.Name, Using = "amount")]
         public IWebElement SliderMovement { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'26')]")]
        public IWebElement RepaymentDate { get; set; }

        [FindsBy(How = How.Id, Using = "monthly")]
        public IWebElement CheckRepaymentDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'£450')]")]
        public IWebElement SliderandLoanAmt { get; set; }

        [FindsBy(How = How.CssSelector, Using = "body.cookie-no-consent:nth-child(2) div.main-wrapper-main-EdHEf215nn div.landing-page div.row:nth-child(1) div.landing-page__container div.right-wrapper div.loan-calculator section.loan-amount:nth-child(1) header.loan-amount__header div.loan-amount__header__range > h3:nth-child(1)")]
        public IWebElement LoanAmt { get; set; }






        /*Selecting Slider values */

        public static int GetPixelsToMoveSlider(IWebElement Slider, decimal Amount, decimal SliderMax, decimal SliderMin)
        {
            int pixels = 0;
            decimal tempPixels = Slider.Size.Width;
            tempPixels = tempPixels / (SliderMax - SliderMin);
            tempPixels = tempPixels * (Amount - SliderMin);
            pixels = Convert.ToInt32(tempPixels);
            return pixels;
        }

        public void ClickandMoveSelectedSliders()
     
        {
            /* Amount Slider Value */

            int PixelsToMove = GetPixelsToMoveSlider(SliderMovement, 20, 25, -5);
            Thread.Sleep(5000);
            Actions action = new Actions(PropertiesCollection.driver);
            action.ClickAndHold(SliderMovement).MoveByOffset((-(int)SliderMovement.Size.Width / 2), 0).MoveByOffset(PixelsToMove, 0).Release().Perform();

        
        }





        /* Assert weekend canr be a repayment date */

        public void SelectRepaymentDate()
        {
            Thread.Sleep(5000);
            RepaymentDate.Click();
            Thread.Sleep(4000);
        }

        public void Check_Repayment_Date(string firstrepayment)
        {
            var RepaymentCheck = PropertiesCollection.driver.FindElement(By.XPath("//span[@class='loan-schedule__tab__panel__detail__tag__text']")).Text;

            Assert.AreEqual(RepaymentCheck, firstrepayment);
        }


        public void CheckMinandMaxAmount(int MinAmount, int MaxAmount)
        {
          //var Min_Max =PropertiesCollection.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/section[1]/div[1]/label[1]/input[1]")).Text;
           // Assert.AreEqual(Min_Max, MinAmount, MaxAmount);
        }

        //public bool assertpayment(string date) => CheckRepaymentDate(date).IsDisplayed();



        /* Assert The min and max amounts of Loan on slider.*/

        public void CheckSliderAmountasLoanAmount(string loanamount)
        {
            var SliderAmount = PropertiesCollection.driver.FindElement(By.XPath("//span[contains(text(),'£450')]")).Text;
            Assert.AreEqual(SliderAmount, loanamount);
        }

        
    }
}
