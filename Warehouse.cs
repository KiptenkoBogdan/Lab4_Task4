using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Task4
{
    public class Warehouse
    {
        public string name;
        float price;
        float volume;
        string arrival_date;
        public Warehouse()
        { }
        public void Add()
        {
            string n, ad;
            float p, v;
            Console.WriteLine("\nInput Name, Price, Volume, Arrival date: ");
            n = Console.ReadLine();
            p = float.Parse(Console.ReadLine());
            v = float.Parse(Console.ReadLine());
            ad = Console.ReadLine();
            this.name = n;
            this.price = p;
            this.volume = v;
            this.arrival_date = ad;
        }
        public void Sorting(Warehouse[] arr)
        {
            Array.Sort(arr, new SortByName());
        }
        public void Get_Info(Warehouse item)
        {
            Console.WriteLine("\nProduct name : " + item.name);
            Console.WriteLine("Product price = " + item.price);
            Console.WriteLine("Product volume = " + item.volume);
            Console.WriteLine("Product date of arrival : " + item.arrival_date);
            Console.WriteLine();
        }
        public void Search_Name(Warehouse item, string name)
        {
            if (item.name == name)
                Get_Info(item);
        }
        public void Search_Price(Warehouse item, float price)
        {
            if (item.price == price)
                Get_Info(item);
        }
        public void Search_Volume(Warehouse item, float volume)
        {
            if (item.volume == volume)
                Get_Info(item);
        }
    }
}
