using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_2
{
    internal class Program
    {
        static void p1()
        {
            //Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 
            int n = int.Parse(Console.ReadLine());
            int nr = 0;
            for( int i= 0; i < n; i++)
            {
                int a= int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                {
                    nr++;
                }
            }
            Console.WriteLine(nr);
            Console.ReadKey();
        }
        static void p2()
        {
            //Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive.
            int n = int.Parse(Console.ReadLine());
            int neg = 0;
            int poz = 0;
            int z = 0;
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a < 0)
                    neg++;
                if (a > 0)
                    poz++;
                if (a == 0)
                    z++;
            }
            Console.WriteLine("In secventa se gasesc " + neg + " numere negative, " + poz + " numere pozitive, iar zero de " + z + " ori");
        }
        static void p3()
        {
            //Calculati suma si produsul numerelor de la 1 la n. 
            ulong n= ulong.Parse(Console.ReadLine());
            ulong s = 0;
            ulong p = 1;
            for(ulong i = 1; i <= n; i++)
            {
                s += i;
                p *= i;
            }
            Console.WriteLine("Suma este egală cu "+ s + " iar produsul este egal cu " + p);
        }
        static void p4()
        {
            //Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. 
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int poz = -1;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == a)
                {
                    poz = i;
                }
            }
            if (poz == -1)
            {
                Console.WriteLine($" {poz} ");
            }
            else
                Console.WriteLine($"Pozitia lui {a} este {poz}");
        }
        static void p5()
        {
            //Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0. 
            int n=int.Parse(Console.ReadLine());
            int e = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == i)
                {
                    e++;
                }
            }
            Console.WriteLine(e);
        }
        static void p6()
        {
            //Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare.
            int n = int.Parse(Console.ReadLine());
            bool a = true;
            int x1 =int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int x2=int.Parse(Console.ReadLine());
                if(x1>x2)
                {
                    a= false;
                }
                x1 = x2;
            }
            if(a)
            {
                Console.WriteLine($"Șirul este în ordine crescătoare.");
            }
            else
                Console.WriteLine($"Șirul nu este în ordine crescătoare.");
        }
        static void p7()
        {
            //Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 

            int n = int.Parse(Console.ReadLine());
            int max = 0;
            int min = 0;
            for(int i = 0; i < n; i++)
            {
                int x=int.Parse(Console.ReadLine());
                if(min==0)
                {
                    min = x;
                }
                if (x < min)
                {
                    min = x;
                }
                if(x > max)
                {
                    max = x;
                }
            }
            Console.WriteLine($" Minimul sirului este {min}, iar maximul sirului este {max}.");
        }
        static void p8()
        {
            //Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...
            int n = int.Parse(Console.ReadLine());
            int f1 = 0;
            int f2 = 1;
            int fn = 0;
            for (int i = 2; i <= n; i++)
            {
                fn = f2 + f1;
                f1 = f2;
                f2 = fn;
            }
            Console.WriteLine($"{fn}");
        }
        static void p9()
        {
            //Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 
            int n = int.Parse(Console.ReadLine());
            bool a1 = true;
            bool a2 = true;
            int x1 = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                int x2 = int.Parse(Console.ReadLine());
                if (x1 > x2)
                {
                    a1 = false;
                }
                if (x1 < x2)
                {
                    a2 = false;
                }
                x1 = x2;
            }
            if (a1 || a2)
            {
                Console.WriteLine($"Sirul este monoton");
            }
            else
                Console.WriteLine($"Sirul nu este monoton");
        }
        static void p10()
        {
            //Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 
            int n = int.Parse(Console.ReadLine());
            int max = 1;
            int nr = 1;
            int x1 = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                int x2 = int.Parse(Console.ReadLine());
                if (x1 == x2)
                {
                    nr++;
                }
                else
                    nr = 1;
                if (nr > max)
                {
                    max = nr;
                }
                x1 = x2;
            }
            Console.WriteLine($"Numarul maxim de numere conscutive din secventa este {max}");
        }
        static void p11()
        {
            //Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere.
            int n = int.Parse(Console.ReadLine());
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                int xinv = 0;
                while (x > 0)
                {
                    xinv = xinv * 10 + x % 10;
                    x /= 10;
                }
                s += xinv;
            }
            Console.WriteLine(s);
        }
        static void p12()
        {
            //Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3.
            int n = int.Parse(Console.ReadLine());
            int nr = 0;
            int x1 = int.Parse(Console.ReadLine());
            if (x1 != 0)
                nr++;
            for (int i = 1; i < n; i++)
            {
                int x2 = int.Parse(Console.ReadLine());
                if (x2 != 0 && x1 == 0)
                    nr++;
                x1 = x2;
            }
            Console.WriteLine(nr);
        }
        static void p13()
        {
            //O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). Determinati daca o secventa de n numere este o secventa crescatoare rotita. 
             int n = int.Parse(Console.ReadLine());
             int x1 = int.Parse(Console.ReadLine());
             int prim = x1;
             int bec = 0;
             for (int i = 1; i < n; i++)
             { 
                int x2 = int.Parse(Console.ReadLine());
                 if (x1 > x2)
                 {
                   bec++;
                 }
                x1 = x2;
             }
             if (bec == 1 && prim > x1)
             {
               Console.WriteLine($"Secventa este crescatoare rotita");
             }
             else  
               Console.WriteLine($"Secventa nu este crescatoare rotita");
        }
        static void p14()
        {
            //O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita.
            int n = int.Parse(Console.ReadLine());
            int x1 = int.Parse(Console.ReadLine());
            int prim = x1;
            int bec1 = 0;
            int bec2 = 0;
            for (int i = 1; i < n; i++)
            {
                int x2 = int.Parse(Console.ReadLine());
                if (x1 > x2)
                {
                    bec1++;
                }
                if (x1 < x2)
                {
                    bec2++;
                }
                x1 = x2;
            }
            if ((bec1 == 1 && prim > x1) ^ (bec2 == 1 && prim < x1))
            {
                Console.WriteLine($"Secventa este monotona rotita");
            }
            else Console.WriteLine($"Secventa nu este monotona rotita");
        }
        static void p15()
        {
            //O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica.
            int n, x, y;
            bool? crescator = null;
            bool ok = true, switched = false;
            n = int.Parse(Console.ReadLine());
            x = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                y = int.Parse(Console.ReadLine());
                if (x < y)
                {
                    if (!crescator.HasValue)
                    {
                        crescator = true;
                    }
                    else if (!crescator.Value && !switched)
                    {
                        switched = true;
                        crescator = true;
                    }
                    else if (!crescator.Value && switched)
                    {
                        ok = false;
                    }
                }
                if (x > y)
                {
                    if (!crescator.HasValue)
                    {
                        crescator = false;
                    }
                    else if (crescator.Value && !switched)
                    {
                        switched = true;
                        crescator = false;
                    }
                    else if (crescator.Value && switched)
                    {
                        ok = false;
                    }
                }
                x = y;
            }
            if (ok && switched == true)
            {
                Console.WriteLine("Secventa este bitonica");
            }
            else
            {
                Console.WriteLine("Secventa nu este bitonica");
            }
        }
        static void p16()
        {
            //O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita.
            int n = int.Parse(Console.ReadLine());
            int x1 = int.Parse(Console.ReadLine());
            bool? crescator = null;
            bool ok = true, switched = false;
            int prim = x1;
            int bec1 = 0;
            int bec2 = 0;
            for (int i = 1; i < n; i++)
            {
                int x2 = int.Parse(Console.ReadLine());
                if (x1 > x2)
                {
                    bec1++;
                }
                if (x1 < x2)
                {
                    bec2++;
                }
                x1 = x2;
                if (x1 < x2)
                {
                    if (!crescator.HasValue)
                    {
                        crescator = true;
                    }
                    else if (!crescator.Value && !switched)
                    {
                        switched = true;
                        crescator = true;
                    }
                    else if (!crescator.Value && switched)
                    {
                        ok = false;
                    }
                }
                if (x1 > x2)
                {
                    if (!crescator.HasValue)
                    {
                        crescator = false;
                    }
                    else if (crescator.Value && !switched)
                    {
                        switched = true;
                        crescator = false;
                    }
                    else if (crescator.Value && switched)
                    {
                        ok = false;
                    }
                }
                x1 = x2;
            }
            if ((bec1 == 1 && prim > x1) ^ (bec2 == 1 && prim < x1) && ok && switched == true)
            {
                Console.WriteLine($"Secventa este bitonica rotita");
            }
            else
                Console.WriteLine($"Secventa nu este bitonica rotita");
        }
        static void p17()
        {
            //Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor. De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta.
            string[] t = Console.ReadLine().Split(' ');
            int zero = 0;
            int unu = 0;
            int a = 0;
            int incuibare = 0;
            int incuibaremax = 0;
            for (int i = 0; i < t.Length; i++)
            {
                a = int.Parse(t[i]);
                if (a == 0)
                {
                    zero++;
                    incuibare++;
                }
                if (a == 1)
                {
                    unu++;
                    incuibare = 0;
                }
                if (incuibare > incuibaremax)
                    incuibaremax = incuibare;
            }
            if (t[0] == "1" || t[t.Length - 1] == "0")
                Console.WriteLine($"Secventa este incorecta");
            else if (unu == zero && a != 0)
                Console.WriteLine($"Secventa este corecta si incuibarea maxima este {incuibaremax}");
            else
                Console.WriteLine($"Secventa este incorecta");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul problemei:");
            int nrp = int.Parse(Console.ReadLine());
            if (nrp == 1)
            {
                Console.WriteLine("Problema " + nrp);
                p1();
            }
            if (nrp == 2)
            {
                Console.WriteLine("Problema " + nrp);
                p2();
            }
            if (nrp == 3)
            {
                Console.WriteLine("Problema " + nrp);
                p3();
            }
            if (nrp == 4)
            {
                Console.WriteLine("Problema " + nrp);
                p4();
            }
            if (nrp == 5)
            {
                Console.WriteLine("Problema " + nrp);
                p5();
            }
            if (nrp == 6)
            {
                Console.WriteLine("Problema " + nrp);
                p6();
            }
            if (nrp == 7)
            {
                Console.WriteLine("Problema " + nrp);
                p7();
            }
            if (nrp == 8)
            {
                Console.WriteLine("Problema " + nrp);
                p8();
            }
            if (nrp == 9)
            {
                Console.WriteLine("Problema " + nrp);
                p9();
            }
            if (nrp == 10)
            {
                Console.WriteLine("Problema " + nrp);
                p10();
            }
            if (nrp == 11)
            {
                Console.WriteLine("Problema " + nrp);
                p11();
            }
            if (nrp == 12)
            {
                Console.WriteLine("Problema " + nrp);
                p12();
            }
            if (nrp == 13)
            {
                Console.WriteLine("Problema " + nrp);
                p13();
            }
            if (nrp == 14)
            {
                Console.WriteLine("Problema " + nrp);
               p14();
            }
            if (nrp == 15)
            {
                Console.WriteLine("Problema " + nrp);
                p15();
            }
            if (nrp == 16)
            {
                Console.WriteLine("Problema " + nrp);
                p16();
            }
            if (nrp == 17)
            {
                Console.WriteLine("Problema " + nrp);
                p17();
            }
            Console.ReadKey();
        }
    }
}
