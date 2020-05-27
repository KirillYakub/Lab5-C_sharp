using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_C_sharb
{
    class Program
    {
        static void Main(string[] args)
        {
            Inform inform = new Inform("12", "10/2", "Shevchenko", "Odesa");
            More(inform);
        }
        static void More(IFlat flat)
        {
            flat.Write();
        }
    }
    class Inform : IFlat
    {
        private string flat, house, street, city;
        public Inform(string flat, string house, string street, string city)
        {
            this.flat = flat;
            this.house = house;
            this.street = street;
            this.city = city;
        }
        private Inform()
        { }
        void IFlat.Write()
        {
            Console.WriteLine($"Квартира: " + this.flat + "\n");
            Console.WriteLine($"Дом: " + this.house + "\n");
            Console.WriteLine($"Улица: " + this.street + "\n");
            Console.WriteLine($"Город: " + this.city + "\n\n");
            Console.ReadLine();
        }
    }
    interface IFlat
    {
        void Write();
    }
}
