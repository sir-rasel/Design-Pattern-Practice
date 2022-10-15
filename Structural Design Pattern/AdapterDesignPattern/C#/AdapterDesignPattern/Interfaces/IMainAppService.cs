using AdapterDesignPattern.Classes;

namespace AdapterDesignPattern.Interfaces
{
    interface IMainAppService
    {
        void DisplayMenus(XmlData xmlData);
        void DisplayRecomendation(XmlData xmlData);
    }
}
