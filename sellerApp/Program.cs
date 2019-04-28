using sellerApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sellerApp
{

    class Program
    {
      
        static void Main(string[] args)
        {
          
            int yas, id;
            Person person = new Person();
            Employee worker = new Employee();
            Client alici = new Client();
            Product produkt = new Product();
            Order sifarish = new Order();
            person.DisplayChoose();
            
            for (; ;)
            {  
                string keyboardInput1 = Console.ReadLine();
                if(keyboardInput1 != "i" && keyboardInput1 != "I" && keyboardInput1 != "m" && keyboardInput1 != "M" && keyboardInput1 != "p" && keyboardInput1 != "P" && keyboardInput1 != "o" && keyboardInput1 != "O"){

                    Console.WriteLine("Yuxarida gosterilenlerden birini secin zehmet olmasa...");
                }               
                switch (keyboardInput1)
                {

                    case "I":
                    case "i":

                        Console.WriteLine("Adinizi daxil edin: ");
                        worker.setName(Console.ReadLine());
                        worker.count();
                        Console.WriteLine("Soyadinizi daxil edin: ");
                        worker.setSurname(Console.ReadLine());
                        Console.WriteLine("Yasinizi daxil edin: ");
                        worker.setAge(Convert.ToByte(Console.ReadLine()));

                        Console.WriteLine("Seriya nomrenizi daxil edin: ");
                        worker.setCardId(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Vezifenizi daxil edin: ");
                        worker.setPosition(Console.ReadLine());
                        Console.WriteLine("Emekhaqqinizin miqdarini  daxil edin: ");
                        worker.setSalary(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Ishci yaradildi: " + " (ishci) - "+ worker.getNum() + " - "+ worker.getFullName() + " " + worker.getAge());

                        person.DisplayChoose();
                        break;
                }
                
                switch (keyboardInput1)
                {

                    case "M":
                    case "m":
                        Console.WriteLine("Adinizi daxil edin: ");
                        alici.setName(Console.ReadLine());
                        alici.count();
                        Console.WriteLine("Soyadinizi daxil edin: ");
                        alici.setSurname(Console.ReadLine());
                        Console.WriteLine("Yasinizi daxil edin: ");
                        alici.setAge(Convert.ToByte(Console.ReadLine()));

                        Console.WriteLine("Seriya nomrenizi daxil edin: ");
                        alici.setCardId(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Adresinizi daxil edin: ");
                        alici.setClAdress(Console.ReadLine());
                        Console.WriteLine("Elaqe nomrenizi  daxil edin: ");
                        alici.setClNumber(Convert.ToInt32(Console.ReadLine()));

                        Console.WriteLine("Mushteri yaradildi: " + "( mushteri ) - " +  alici.getNum() + " - " + alici.getFullName() + " " + alici.getAge());

                        person.DisplayChoose();

                        break;
                }
              

                switch (keyboardInput1)
                {

                    case "P":
                    case "p":
                        Console.WriteLine("Produkt adini daxil edin: ");
                        produkt.ProductName = Console.ReadLine();
                        produkt.count1();
                        Console.WriteLine("Produkt rengini daxil edin: ");
                        produkt.ProductColor = Console.ReadLine();
                        Console.WriteLine("Qiymeti daxil edin: ");
                        produkt.ProductPrice = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Mehsul yaradildi: " + "( mehsul ) - " + produkt.getNum1() + " - "  + produkt.ProductName + " " + produkt.ProductColor + "  -  " + produkt.ProductPrice);
                        person.DisplayChoose();
                        break;
                }
               

                switch (keyboardInput1)
                {

                    case "O":
                    case "o":

                        sifarish.ClientProduct = produkt;
                        sifarish.CLientOrder = alici;
                        sifarish.count2();
                        sifarish.ProduktQiymeti = produkt.ProductPrice;
                        Console.WriteLine("Produkt sayini daxil edin: ");
                        sifarish.Count = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Sifarish yaradildi: ");
                        Console.WriteLine(  "ID - " + sifarish.getNum2() + " - " +   produkt.ProductName + " " + alici.getFullName()+ " " +"terefinden sifarish olundu." + " Sayi - " + sifarish.Count + ", " +"cemi mebleg: "+sifarish.totalPrice());
                        Console.WriteLine("Sifarishi qebul eden ishci: " + worker.getFullName() + " " + worker.getPosition());

                        break;
                }
            }
          
          
        }
    }
}

class Product
    {
        public string ProductName { get; set; }
        public string ProductColor  { get; set; }
        public int ProductPrice { get; set; }

    
        public  int num1;
      
      public void count1() {
         num1++;
      }
      public int getNum1() {
         return num1;
      }
    }

    class Order 
    {
        public Product ClientProduct { get; set; }
        public Client CLientOrder { get; set; }
    public int ProduktQiymeti { get; set; }
    public int Count { get; set; }
        public int totalPrice()
        {
            return Count * ProduktQiymeti;
        }
    
        public  int num2;
      
      public void count2() {
         num2++;
      }
      public int getNum2() {
         return num2;
      }
    }

