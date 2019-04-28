using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sellerApp
{
    class Client : Person

    {
        public int _clienetId;
        public string _clientAdress;
        public int _clientPhone;

        //public Client(string name, string surname, byte age, int Cid) : base(name, surname, age, Cid) { }
        public void setClAdress(string clientAdress)
        {
            _clientAdress = clientAdress;
        }
        public string getAdress()
        {
            return _clientAdress;
        }
        public void setClNumber(int clientPhone)
        {
            _clientPhone = clientPhone;
        }
        public int getPhone()
        {
            return _clientPhone;
        }


    }
}
