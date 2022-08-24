using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    internal class Program
    {

        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r = Convert.ToDouble(Console.ReadLine());

            MyDelegate myDelegate = CircleLength;
            double D = myDelegate(r);
            Console.WriteLine("{0:.00}",D);

            myDelegate = CircleArea;
            double S = myDelegate(r);
            Console.WriteLine("{0:.00}",S);

            myDelegate = CircleVolume;
            double V = myDelegate(r);
            Console.WriteLine("{0:.00}",V);

            Console.ReadKey();  
        }

        //static double CircleLength(double r)
        //{
        //    double D = 2*r*Math.PI;
        //    return D;
        //}
        static double CircleLength(double r) => (double)(2 * r * Math.PI);


        //static double CircleArea(double r)
        //{
        //    double S = Math.PI * r * r;
        //    return S;   
        //}

        static double CircleArea(double r) => (double)(Math.PI * r * r);

        //static double CircleVolume(double r)
        //{
        //    double V = 4 / 3 * Math.PI * r * r * r;
        //    return V;
        //}
        static double CircleVolume(double r) => (double)(4 / 3 * Math.PI * r * r * r);

    }
}
