using AdapterDesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern.Classes
{
    class ThirdPartyUIServiceAdapter : IMainAppService
    {
        private ThirdPartyUISerrvice _thirdPartyUISerrvice { get; set; }

        public ThirdPartyUIServiceAdapter()
        {
            _thirdPartyUISerrvice = new ThirdPartyUISerrvice();
        }

        public void DisplayMenus(XmlData xmlData)
        {
            var convertedJsonData = ConvertXmlToJsonData(xmlData);
            _thirdPartyUISerrvice.DisplayMenus(convertedJsonData);
        }

        public void DisplayRecomendation(XmlData xmlData)
        {
            var convertedJsonData = ConvertXmlToJsonData(xmlData);
            _thirdPartyUISerrvice.DisplayRecomendation(convertedJsonData);
        }

        public JsonData ConvertXmlToJsonData(XmlData xmlData)
        {
            return new JsonData();
        }
    }
}
