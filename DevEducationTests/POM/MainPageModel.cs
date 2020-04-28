using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTests.POM
{
    public class MainPageModel
    {
        public string mainLabelTagName = "h1";
        public string courseMenuButtonXPath= "/html/body/div[1]/div[1]/header/div/div[1]/nav/ul/li[1]/a";
        public string graduatesMenuButton;
        public string newsMenuButton;
        public string blogMenuButton;
        public string aboutUsMenuButton;
        public string contactsMenuButton;
        public string selectLanguageButton;
        public string policyButtonXpath = "/html/body/div[1]/footer/div/div[1]/a";

        public string socialNetworkLinksClassName = "ofooter-icons__item";


    }
}
