using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class1
    {
        public string nazv { get; set; }
        public double S_bas { get; set; }
        public double prot { get; set; }
        public Class1()
        {
            nazv = "Dvina";
            S_bas = 180;
            prot = 6054;
        }
        public Class1(string a, double b, double c)
        {
            nazv = a;
            S_bas = b;
            prot = c;
        }
        public void vvod()
        {
            Console.WriteLine("навзание реки");
            nazv = Console.ReadLine();
            Console.WriteLine("площадь бассейна");
            S_bas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("протяженность");
            prot = Convert.ToDouble(Console.ReadLine());
        }
        public void vivod()
        {
            Console.WriteLine(nazv);
            Console.WriteLine(S_bas);
            Console.WriteLine(prot);
        }
    }
}

    

