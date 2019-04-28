using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sellerApp
{
    class Person
    {
        public void DisplayChoose()
        {
            Console.WriteLine("Sechim edin: ");
            Console.WriteLine("I - Ishci yaratmaq  ");
            Console.WriteLine("M - Mushteri yaratmaq  ");
            Console.WriteLine("P - Mehsul yaratmaq  ");
            Console.WriteLine("O - Sifarish yaratmaq  ");
        }
        string Year = DateTime.Parse(DateTime.Now.ToString()).Year.ToString();
        

        public  int num;
      
      public void count() {
         num++;
      }
      public int getNum() {
         return num;
      }
        protected string _Name;
        protected string _Surname;
        protected byte _Age;
        protected int _CardId;

        public void setName(string name)
        {
            _Name = name;
        }

        public void setSurname(string surname)
        {
            _Surname = surname;
        }
        public string getFullName()
        {
            return _Name + " " + _Surname;
        }
        public void setAge(byte age)
        {
            _Age = age;
        }
        public byte getAge()
        {
            return _Age;
        }
        public void setCardId(int Cid)
        {
            _CardId = Cid;
        }
    }
}
