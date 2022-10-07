using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDesignPattern.Classes
{
    class ThirdPartyUISerrvice
    {
        public void DisplayMenus(JsonData jsonData)
        {
            Console.WriteLine("Display Menu using Json data");
        }

        public void DisplayRecomendation(JsonData jsonData)
        {
            Console.WriteLine("Display Recomendation using Json data");
        }
    }
}
