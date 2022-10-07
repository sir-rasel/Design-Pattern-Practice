using AdapterDesignPattern.Interfaces;
using System;

namespace AdapterDesignPattern.Classes
{
    class MainAppService : IMainAppService
    {
        public void DisplayMenus(XmlData xmlData)
        {
            Console.WriteLine("Display Menu using XML data");
        }

        public void DisplayRecomendation(XmlData xmlData)
        {
            Console.WriteLine("Display Recomendation using XML data");
        }
    }
}
