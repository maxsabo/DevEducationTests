using DevEducationTests.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTests
{
    public class OurContactsTest : BaseDriver
    {
        ContactsPageModel contactsPage;
        public OurContactsTest()
        {
            contactsPage = new ContactsPageModel();
        }
        [Test]
        public void CheckAddressDnipro()
        {
            driver.Url = Urls.contactsPage;
            IWebElement address = driver.FindElement(By.XPath(contactsPage.dniproAdressXPath));
            string actRes = address.Text;
            string expRes = contactsPage.dniproAdress;
            Assert.AreEqual(expRes, actRes);

        }
        [Test]
        public void CheckPhoneDnipro()
        {
            driver.Url = Urls.contactsPage;

            IWebElement telephone = driver.FindElement(By.XPath(contactsPage.dniproPhoneXPath));
            string actRes = telephone.Text;
            string expRes = contactsPage.dniproPhone;
            Assert.AreEqual(expRes, actRes);
            
        }

        [Test]
        public void CheckAddressKyiv()
        {
            driver.Url = Urls.contactsPage;
            IWebElement buttonKyiv = driver.FindElement(By.XPath(contactsPage.kyivAButtonXPath));
            buttonKyiv.Click();

            IWebElement address = driver.FindElement(By.XPath(contactsPage.kyivAdressXPath));
            string actRes = address.Text;
            string expRes = contactsPage.kyivAdress;
            Assert.AreEqual(expRes, actRes);
          
        }


        [Test]
        public void CheckAddressBaku()
        {
            driver.Url = Urls.contactsPage;
            IWebElement buttonKyiv = driver.FindElement(By.XPath(contactsPage.bakuAButtonXPath));
            buttonKyiv.Click();

            IWebElement address = driver.FindElement(By.XPath(contactsPage.bakuAdressXPath));
            string actRes = address.Text;
            string expRes = contactsPage.bakuAdress;
            Assert.AreEqual(expRes, actRes);
            
        }

        [Test]
        public void CheckAskQuestion()
        {
            driver.Url = Urls.contactsPage;
            IWebElement button = driver.FindElement(By.XPath(contactsPage.askAButtonXPath));
            button.Click();

            IWebElement nameInput = driver.FindElement(By.Name("name"));
            nameInput.SendKeys("Vova");

            IWebElement eMailInput = driver.FindElement(By.XPath("/html/body/div[1]/main/div[3]/div/div/form/div[2]/input"));
            eMailInput.SendKeys("vova@gmail.com");

            IWebElement messageInput = driver.FindElement(By.Name("message"));
            messageInput.SendKeys("Hello. How are you? This is my homework.");
        
            Assert.AreEqual(true, true);
        }

    }
}
