using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Krozek1
{
    class Program
    {
        enum Days { Sat = 1, Sun, Mon, Tue, Wed, Thu, Fri };

        static void Main(string[] args)
        {

            /*
             * string x;
            x = Console.ReadLine();
            Console.WriteLine(x + " Ziga");
             */

            //komentar

            int stevilo = 5;
            double decimalka = 1.5;
            bool jeRes = true;

            //decimalka = Convert.ToInt32(decimalka);
            //decimalka = (int)decimalka;

            char zacetnica = 'Ž';

            //Console.WriteLine(zacetnica);



            int[] numArray = { 1903, 1907, 1910 };
            int[] arr = new int[3];

            //Console.WriteLine(arr[0]);

            //int x[5];
            //int x[2,3];

            int[,] nums = { { 1907, 1990 }, 
                            { 1904, 1986 }, 
                            { 1910, 1980 } }; //tabela 3x2

            

            int[,] arr2 = new int[3, 3]; //tabela 3x3

            //arr2 = nums;
            /*arr2[1, 1] = nums[1, 1];

            Console.WriteLine(arr2[1,1]);
            nums[1, 1] = 123;
            Console.WriteLine(arr2[1, 1]);*/

            




            /*int num1 = 10;
            int num2 = 10;
            Console.WriteLine(num1 + " " + num2);
            func(ref num1,ref num2);
            Console.WriteLine(num1 + " " + num2);*/

            List<int> myList = new List<int>();
            myList.Add(1); //0
            myList.Add(5); //1
            myList.Add(-6); //2
            myList.Add(11111); //3

            /*myList.ElementAt(index);
            myList[index]*/

            /*Console.WriteLine(myList.ElementAt(2));
            myList.RemoveAt(2);
            Console.WriteLine(myList[2]);

            Console.WriteLine(myList.Count);*/


            /*string alpha = "abcdef";
            Console.WriteLine(alpha);
            Console.WriteLine(alpha[0]);



            string s = alpha.Substring(2);
            Console.WriteLine(s);
            
            s = alpha.Substring(3,2);
            Console.WriteLine(s);


            int y = 5;
            if ("qwe" == "qwe")
            {
                Console.WriteLine("ja");
            }
            else
            {
                Console.WriteLine("ne");
            }*/

            /*int[] array = { 3, 5, 0, -2, 6 };
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }*/



            //Array.Sort(array);
            //Console.WriteLine(array[0] + " " + array[4]);

            /*Days d = Days.Mon;

            if (d == Days.Mon) 
            {
                Console.WriteLine("ja");
            }
            else
            {
                Console.WriteLine("ne");
            }*/


            Hrana pizza = new Hrana();
            /*pizza.DodajSestavine("sir");
            pizza.DodajSestavine("testo");
            pizza.DodajSestavine("paradižnik");*/

            //string[] s = { "sir", "testo", "paradiznik" };
            pizza.DodajSestavine("sir", "testo", "paradiznik");

            string[] sestavine = pizza.PridobiSestavine();
            foreach (string i in sestavine)
            {
                Console.WriteLine(i);
            }



            Console.ReadKey();
        }

        static void func(ref int i1, ref int i2)
        {
            i1 = 99;
            i2 = 22;
        }

        class Hrana
        {
            List<string> sestavine;
            public Hrana()
            {
                sestavine = new List<string>();
            }
            public void DodajSestavine(string sestavina)
            {
                sestavine.Add(sestavina);
            }
            public void DodajSestavine(params string[] sestavine)
            {
                foreach (string sestavina in sestavine)
                {
                    this.sestavine.Add(sestavina);
                }
            }
            public string[] PridobiSestavine()
            {
                return sestavine.ToArray();
            }
        }
    }
}
