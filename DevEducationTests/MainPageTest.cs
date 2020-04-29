using DevEducationTests.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace DevEducationTests
{
    public class MainPageTest : BaseDriver
    {
        MainPageModel pageModel;
        CoursesPageModel coursesModel;
        MapModel mapModel;
        LanguageModel langModel;
        SocialNetworksModel socNet;

        public MainPageTest()
        {
            pageModel = new MainPageModel();
            coursesModel = new CoursesPageModel();
            mapModel = new MapModel();
            langModel = new LanguageModel();
            socNet = new SocialNetworksModel();
        }
        [Test]
        public void CheckMainLabel()
        {
            driver.Url = Urls.mainPage;
            IWebElement mainLabel = driver.FindElement(By.TagName(pageModel.mainLabelTagName));
            string actResult = mainLabel.Text;
            Assert.AreEqual("Международный IT-колледж", actResult);
        }
        [Test]

        public void CheckCourses()
        {
            driver.Url = Urls.mainPage;
            IWebElement coursesButton = driver.FindElement(By.XPath(pageModel.courseMenuButtonXPath));
            coursesButton.Click();
            IWebElement ourCoursesLabel = driver.FindElement(By.TagName(coursesModel.ourCoursesLabelTagName));
            string actResult = ourCoursesLabel.Text;
            Assert.AreEqual("Наши курсы", actResult);
        }
        //New tests 
        //1. Map
        [Test]
        public void CheckSPB()
        {
            driver.Url = Urls.mainPage;
            IWebElement spbButton = driver.FindElement(By.XPath(mapModel.spbMapXpath));
            spbButton.Click();
            IWebElement spbLocal = driver.FindElement(By.XPath(mapModel.spbLocalXpath));
            string actResult = spbLocal.Text;
            Assert.AreEqual("Санкт-Петербург", actResult);
        }
        [Test]
        public void CheckKyiv()
        {
            driver.Url = Urls.mainPage;
            IWebElement kyivButton = driver.FindElement(By.XPath(mapModel.kyivMapXpath));
            kyivButton.Click();
            IWebElement kyivLocal = driver.FindElement(By.XPath(mapModel.kyivLocalXpath));
            string actResult = kyivLocal.Text;
            Assert.AreEqual("Киев", actResult);
        }
        [Test]
        public void CheckDnepr()
        {
            driver.Url = Urls.mainPage;
            IWebElement dneprButton = driver.FindElement(By.XPath(mapModel.dneprMapXpath));
            dneprButton.Click();
            IWebElement dneprLocal = driver.FindElement(By.XPath(mapModel.dneprLocalXpath));
            string actResult = dneprLocal.Text;
            Assert.AreEqual("Днепр", actResult);
        }
        [Test]
        public void CheckKharkow()
        {
            driver.Url = Urls.mainPage;
            IWebElement kharkowButton = driver.FindElement(By.XPath(mapModel.kharkowMapXpath));
            kharkowButton.Click();
            IWebElement kharkowLocal = driver.FindElement(By.XPath(mapModel.kharkowLocalXpath));
            string actResult = kharkowLocal.Text;
            Assert.AreEqual("Харьков", actResult);
        }
        [Test]
        public void CheckBaku()
        {
            driver.Url = Urls.mainPage;
            IWebElement bakuButton = driver.FindElement(By.XPath(mapModel.bakuMapXpath));
            bakuButton.Click();
            IWebElement bakuLocal = driver.FindElement(By.XPath(mapModel.bakuLocalXpath));
            string actResult = bakuLocal.Text;
            Assert.AreEqual("Баку", actResult);
        }
        //2. Language
        [Test]
        public void ChangeToUa()
        {
            driver.Url = Urls.mainPage;
            IWebElement langSwitcher = driver.FindElement(By.XPath(langModel.languageSwitcherButtonXpath));
            langSwitcher.Click();
            IWebElement uaSwitcher = driver.FindElement(By.XPath(langModel.uaSwitcherXpath));
            uaSwitcher.Click();
            IWebElement uaLocal = driver.FindElement(By.XPath(langModel.uaLocalXpath));
            string actResult = uaLocal.Text;
            Assert.AreEqual("UA", actResult);
        }
        [Test]
        public void ChangeToEn()
        {
            driver.Url = Urls.mainPage;
            IWebElement langSwitcher = driver.FindElement(By.XPath(langModel.languageSwitcherButtonXpath));
            langSwitcher.Click();
            IWebElement enSwitcher = driver.FindElement(By.XPath(langModel.enSwitcherXpath));
            enSwitcher.Click();
            IWebElement enLocal = driver.FindElement(By.XPath(langModel.enLocalXpath));
            string actResult = enLocal.Text;
            Assert.AreEqual("EN", actResult);
        }
        [Test]
        public void ChangeToAz()
        {
            driver.Url = Urls.mainPage;
            IWebElement langSwitcher = driver.FindElement(By.XPath(langModel.languageSwitcherButtonXpath));
            langSwitcher.Click();
            IWebElement azSwitcher = driver.FindElement(By.XPath(langModel.azSwitcherXpath));
            azSwitcher.Click();
            IWebElement azLocal = driver.FindElement(By.XPath(langModel.azLocalXpath));
            string actResult = azLocal.Text;
            Assert.AreEqual("AZ", actResult);
        }
        //3. Privacy
        [Test]
        public void CheckPolicy()
        {
            driver.Url = Urls.mainPage;
            IWebElement policyLink = driver.FindElement(By.XPath(pageModel.policyButtonXpath));
            policyLink.Click();
            IWebElement policyLabel = driver.FindElement(By.XPath(socNet.policyXpath));
            string ActRes = policyLabel.Text;
            Assert.AreEqual("Политика конфиденциальности", ActRes);
        }
        //4. Social Networks
        [Test]
        public void CheckInstagram()
        {
            driver.Url = Urls.mainPage;
            IWebElement indtagramLink = driver.FindElements(By.ClassName(pageModel.socialNetworkLinksClassName))[2];
            indtagramLink.Click();
            List<string> tabs = new List<string>(driver.WindowHandles);
            driver.SwitchTo().Window(tabs[1]);
            IWebElement instagramLabel = driver.FindElement(By.TagName(socNet.instaImageTagName));

            string ActRes = instagramLabel.Text;

            Assert.AreEqual("Dev.education", ActRes);
        }
        [Test]
        public void CheckVk()
        {
            driver.Url = Urls.mainPage;
            IWebElement VkLink = driver.FindElements(By.ClassName(pageModel.socialNetworkLinksClassName))[3];
            VkLink.Click();
            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            List<string> tabs = new List<string>(driver.WindowHandles);
            driver.SwitchTo().Window(tabs[1]);
            IWebElement VkLabel = driver.FindElement(By.TagName(socNet.vkTagName));
            string ActRes = VkLabel.Text;

            Assert.AreEqual("DevEducation", ActRes);
        }

        [Test]
        public void CheckYouTube()
        {
            driver.Url = Urls.mainPage;
            IWebElement ToutubeLink = driver.FindElements(By.ClassName(pageModel.socialNetworkLinksClassName))[4];
            ToutubeLink.Click();
            List<string> tabs = new List<string>(driver.WindowHandles);
            driver.SwitchTo().Window(tabs[1]);
            IWebElement title = driver.FindElement(By.XPath("/html/body/ytd-app/div/ytd-page-manager/ytd-browse/div[3]/ytd-c4-tabbed-header-renderer/app-header-layout/div/app-header/div[2]/div[2]/div/div[1]/div/div[1]/ytd-channel-name/div/div/yt-formatted-string"));
            string ActRes = title.Text;

            Assert.AreEqual("DevEducation", ActRes);
        }
        [Test]
        public void CheckLinkDin()
        {
            driver.Url = Urls.mainPage;
            IWebElement linkDinLink = driver.FindElements(By.ClassName(pageModel.socialNetworkLinksClassName))[5];
            linkDinLink.Click();
            List<string> tabs = new List<string>(driver.WindowHandles);
            driver.SwitchTo().Window(tabs[1]);
            IWebElement title = driver.FindElement(By.TagName("h1"));
            string ActRes = title.Text;
            Assert.AreEqual("DevEducation", ActRes);
        }

        [Test]
        public void CheckTwitter()
        {
            driver.Url = Urls.mainPage;
            IWebElement linkTwitter = driver.FindElements(By.ClassName(pageModel.socialNetworkLinksClassName))[6];
            linkTwitter.Click();
            List<string> tabs = new List<string>(driver.WindowHandles);
            driver.SwitchTo().Window(tabs[1]);
            IWebElement title = driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/main/div/div/div/div[1]/div/div[1]/div[1]/div/div/div/div/div[2]/div/h2/div/div/div/span[1]/span/span"));
            string ActRes = title.Text;

            Assert.AreEqual("Deveducation", ActRes);
        }
    }
}
