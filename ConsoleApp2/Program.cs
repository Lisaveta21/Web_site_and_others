using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
////Exercise 4
//    internal class Exercise_4
//    {
//        private const string website = "Our life";
//        private const string path = "//C:";
//        private const string description = "...";
//        private const string ip = "123.223.78";

//        class Work_with_data
//        {
//            int USER_data;
//            public virtual void Input()
//            {
//                Console.WriteLine("Можете ввести данные");
//                Console.ReadLine();
//                USER_data = 0;

//            }
//            public virtual void Output()
//            {
//                Console.WriteLine("Данные выводятся..");
//            }

//        }



//        static void Main(string[] args)
//        {
//            Work_with_data data = new Work_with_data();
//            data.Input();
//            data.Output();
//            Console.WriteLine();
//            Console.WriteLine();



//        }
//    }
    //Exercise 6

    class Shop
    {
        public Shop(string v1, string v2, string v3, string v4, string v5, string v6)
        {
        }

        public class shop
        {
            private string name;
            private string Address;
            private string Year;
            private string description;
            public string phone ;
            public string email ;

            public string shopname
            { 
                get { return name; }
            }
            public string shopaddress
            {
                get { return Address; }
            }
            public string shopyear
            {
                get { return Year; }

            }

            public string shopdescription
            {
                get { return description; }

            }
            public string shopphone
            {
                get { return phone; }

            }
            public string shopemail
            {
                get { return email; }

            }

            public shop(string name, string Address, string year, string description, string phone, string email)
            {

                this.name = name;
                this.Address = Address;
                this.email = email;
                this.phone = phone;
                this.Year = Year;
                this.description = description;

            }
            static void Main(string[]args)
            {
                List<Shop> shops = new List<Shop>();    
                shops.Add(new Shop("Мерч", "ул. такая то дом такой", "sth.@mail.com", "8(888)123 - 12-01", "2023", "Здесь все о культуре.."));

            }





        }

    }
}
