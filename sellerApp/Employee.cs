using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sellerApp
{
    class Employee : Person
    {
        public int _Salary;
        public string _Position;

       
        public void setSalary(int salary)
        {
            _Salary = salary;
        }
        public void setPosition(string position)
        {
            _Position= position;
        }
        public string getPosition()
        {
            return _Position;
        }
    }
}
