using AdapterDesignPattern.Classes;
using AdapterDesignPattern.Interfaces;
using System;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlData myData = new XmlData();

            // Old UI
            IMainAppService multiRestoApp = new MainAppService();
            multiRestoApp.DisplayMenus(myData);
            multiRestoApp.DisplayRecomendation(myData);

           Console.WriteLine("==========================================");

            // New UI
            IMainAppService adapter = new ThirdPartyUIServiceAdapter();
            adapter.DisplayMenus(myData);
            adapter.DisplayRecomendation(myData);
        }
    }
}
