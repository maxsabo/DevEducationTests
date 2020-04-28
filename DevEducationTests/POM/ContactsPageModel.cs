using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationTests.POM
{
    class ContactsPageModel
    {
        public string contactsLabelTagName = "h1";
        public string dniproAdressXPath = "/html/body/div[1]/main/section[1]/div/div[2]/div[1]/div[1]/div[2]/div[1]";
        public string dniproAdress = "ул.Симферопольская, 17";

        public string dniproPhoneXPath = "/html/body/div[1]/main/section[1]/div/div[2]/div[1]/div[1]/div[2]/div[2]";
        public string dniproPhone = "+38 096 861 73 72";

        public string kyivAButtonXPath = "/html/body/div[1]/main/section[1]/div/div[1]/button[2]";
        public string kyivAdressXPath = "/html/body/div[1]/main/section[1]/div/div[2]/div[2]/div[1]/div[2]/div[1]";
        public string kyivAdress = "ст. метро Васильковская, ул. Сумская,1";

        public string bakuAButtonXPath = "/html/body/div[1]/main/section[1]/div/div[1]/button[3]";
        public string bakuAdressXPath = "/html/body/div[1]/main/section[1]/div/div[2]/div[3]/div[1]/div[2]/div[1]";
        public string bakuAdress = "проспект Бабека 10E, Rusel Plaza, 7 этаж";

        public string askAButtonXPath = "/html/body/div[1]/main/section[2]/div/button";
    }
}
