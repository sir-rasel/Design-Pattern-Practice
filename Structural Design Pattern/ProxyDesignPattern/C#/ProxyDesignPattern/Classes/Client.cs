using ProxyDesignPattern.Interfaces;

namespace ProxyDesignPattern.Classes
{
    class Client
    {
        public void ClientCode(ISubject subject)
        {
            subject.Request();
        }
    }
}
