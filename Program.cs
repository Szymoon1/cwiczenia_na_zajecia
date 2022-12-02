using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace ConsoleApp2
{
    internal class Program
    {/*
        //Napisz  program  wczytujący  z  klawiatury  n  liczb  całkowitych.  Program  ma  znaleźć  największą  spośród podanych liczb i wydrukować ją na ekranie.
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ile liczb");
            int n = int.Parse(Console.ReadLine());
            int[] table = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj liczbę");
                int temp = int.Parse(Console.ReadLine());
                table[i] = temp;
            }

            int max = table[0];
            foreach(int row in table)
            {
                if(row>max)
                {
                    max = row;
                }
            }
            Console.WriteLine("Max="+max);
        }
        //Napisz  program  wczytujący  z  klawiatury  n  liczb  całkowitych.  Program  ma  znaleźć  najmniejszą  spośród podanych liczb i wydrukować ją na ekranie.
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ile liczb");
            int n = int.Parse(Console.ReadLine());
            int[] table = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj Liczbę");
                int t = int.Parse(Console.ReadLine());
                table[i] = t;
            }

            int min = table[0];
            foreach(int row in table)
            {
                if(row<min)
                {
                    min = row;
                }
            }
            Console.WriteLine("Min="+min);

        }
        //Napisz  program  wczytujący  z  klawiatury  n  liczb  całkowitych.  Program  ma  znaleźć  największą  spośród podanych 
        //liczb oraz wydrukować na ekranie informację mówiącą o tym, ile razy największa liczba wystąpiła w podanym ciągu liczb.
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ilo licz");
            int n = int.Parse(Console.ReadLine());
            int[] table = new int[n];
            
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj Liczby");
                int t = int.Parse(Console.ReadLine());
                table[i] = t;
            }
            int a = 0;
            int max = table[0];
            foreach(int row in table)
            {
                if(row>=max)
                {
                    max = row;
                    a++;
                }
            }
            Console.WriteLine("Max={0}, powtórzyła się {1}", max, a++);
        }
        //Napisz  program  wczytujący  z  klawiatury  n  liczb  całkowitych.  Program  ma  znaleźć  najmniejszą  spośród podanych 
        //liczb oraz wydrukować na ekranie informację mówiącą o tym, ile razy najmniejsza liczba wystąpiła w podanym ciągu liczb.
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ile liczb");
            int n = int.Parse(Console.ReadLine());
            int[] table = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj liczby");
                int t = int.Parse(Console.ReadLine());
                table[i] = t;
            }

            int p = 0;
            int min = table[0];
            foreach(int row in table)
            {
                if(row<min)
                {
                    min = row;
                    p++;
                }
            }
            Console.WriteLine("Min={0} powtórzyło się {1}",min, p++);
        }
         //Napisz program wczytujący ciąg liczb rzeczywistych. Każdą podana liczbę należy podnieść do kwadratu, a następnie wydrukować na ekranie.   
        static void Main(string[] args)
        {
            Console.WriteLine("podaj ile liczb");
            int n = int.Parse(Console.ReadLine());
            int[] table1 = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj liczbe");
                int t = int.Parse(Console.ReadLine());
                table1[i] = t;
            }
            Console.WriteLine("");
            foreach (int table in table1)
            {
                Console.WriteLine(Math.Pow(table, 2));
            }
        }
        //Napisz  program  wczytujący  ciąg  liczb  rzeczywistych.  Każdą  podana  liczbę  należy  podnieść  do  trzeciej  potęgi, a następnie wydrukować na ekranie.
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ile liczb");
            int n =int.Parse(Console.ReadLine());
            int[] table = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj liczbę");
                int t= int.Parse(Console.ReadLine());
                table[i] = t;
            }
            Console.WriteLine("");
            foreach(int p in table)
            {
                Console.WriteLine(Math.Pow(p,3));
            }
        }
        //Napisz  program  wczytujący  ciąg  liczb  rzeczywistych.  Do  każdej  podanej  liczby  należy  dodać  jeden.  Tak  otrzymane liczby należy wydrukować na ekranie.
        static void Main(string[] args)
        {
            Console.WriteLine("podaj ile liczb");
            int n = int.Parse(Console.ReadLine());
            int[] table = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("podaj liczbe");
                int t = int.Parse(Console.ReadLine());
                table[i] = t;
            }

            foreach(int p in table)
            {
                Console.WriteLine(p+1);
            }
        }
        //Napisz  program  wczytujący  ciąg  liczb  rzeczywistych.  Każdą  podaną  liczbę  należy  pomnożyć  przez  dwa.  Tak otrzymane liczby należy wydrukować na ekranie.
        static void Main(string[] args)
        {
            Console.WriteLine("podaj ile liczb");
            int n = int.Parse(Console.ReadLine());
            int[] table = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("podaj liczbe");
                int t = int.Parse(Console.ReadLine());
                table[i] = t;
            }

            foreach (int p in table)
            {
                Console.WriteLine(p * 2);
            }
        }
        //Napisz  program  wczytujący  ciąg  liczb  całkowitych.  Wydrukuj  na  ekranie  kolejno  wszystkie  parzyste  spośród podanych liczb.
        static void Main(string[] args)
        {
            Console.WriteLine("podaj ile liczb");
            int n = int.Parse(Console.ReadLine());
            int[] table = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("podaj liczbe");
                int t = int.Parse(Console.ReadLine());
                table[i] = t;
            }
            Console.WriteLine("");
            foreach(int p in table)
            {
                if(p%2 ==0)
                {
                    Console.WriteLine(p);
                }
            }
        }
        //Napisz  program  wczytujący  ciąg  liczb  całkowitych.  Wydrukuj  na  ekranie  kolejno  wszystkie  nieparzyste  spośród podanych liczb.
        static void Main(string[] args)
        {
            Console.WriteLine("podaj ile liczb");
            int n = int.Parse(Console.ReadLine());
            int[] table = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("podaj liczbe");
                int t = int.Parse(Console.ReadLine());
                table[i] = t;
            }
            Console.WriteLine("");
            foreach (int p in table)
            {
                if (p % 2 != 0)
                {
                    Console.WriteLine(p);
                }
            }
        }
        //Napisz  program  wczytujący  ciąg  liczb  całkowitych.  Wydrukuj  na  ekranie  kolejno  wszystkie  liczby,  które  dzielą się przez 3. 
        static void Main(string[] args)
        {
            Console.WriteLine("podaj ile liczb");
            int n = int.Parse(Console.ReadLine());
            int[] table = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("podaj liczbe");
                int t = int.Parse(Console.ReadLine());
                table[i] = t;
            }
            Console.WriteLine("");
            int k = 3;
            foreach(int p in table)
            {
                if(p % k ==0)
                {
                    Console.WriteLine(p);
                }
            }
        }
        //Napisz program wczytujący ciąg liczb rzeczywistych. Wydrukuj na ekranie kolejno wszystkie liczby, które należą do przedziału [4;15).
        static void Main(string[] args)
        {
            Console.WriteLine("podaj liczbe");
            int n = int.Parse(Console.ReadLine());
            int[] table = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("podaj liczbe");
                int t = int.Parse(Console.ReadLine());
                table[i] = t;
            }
            Console.WriteLine("");
            foreach(int p in table)
            {
                if(p>=4 && p <15)
                {
                    Console.WriteLine(p);
                }
            }
        }
        
        static void Main(string[] args)
        {
            int n=101;
            for(int i = 1; i < n; i++)
            {
                if(i % 2 ==0)
                {
                    Console.WriteLine(i+100);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            
            Console.ReadKey();
        }*/
        // rozkład na czynniki pierwsze
        static ArrayList naCzynniki(int liczba)
        {
            ArrayList list = new ArrayList();
            int k = 2;
            while(liczba!=1)
            {
                while(liczba%k==0)
                {
                    liczba = liczba / k;
                    list.Add(k);
                }
                k++;
            }
            return list; 
        }

        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Podaj liczbę do rozkładu na czynniki pierwsze");
                int t = int.Parse(Console.ReadLine());
                ArrayList lista = naCzynniki(t);
                foreach (var a in lista)
                {
                    Console.WriteLine(a);
                    Console.WriteLine("");
                }
            }
            while (true);
            Console.ReadKey();
        }
        
    }
}
