using System;
using System.Linq;

namespace ProgLang
{
    class Program
    {
        static void Main()
        {
            double[] h = Console.ReadLine().Split(' ').Select(x => double.Parse(x)).ToArray();
            double v = double.Parse(Console.ReadLine());

            Array.Sort(h);
            for (int i = 0; i < h.Length; i++)
            {
                int g = (int)h[i];
                if (g % 2 == 0)
                {
                    Console.Write(h[i] + " ");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < h.Length; i++)
            {
                int k = (int)h[i];
                if (k % 2 != 0 && h[i] > v)
                {
                    Console.Write(h[i] + " ");
                }
            }
        }
    }
}















//1 Циклы не рабочее
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//List<int> f = new List<int>();
//List<int> k = new List<int>();
//while (a % 10 > 1)
//{
//    f.Add(a);
//}
//while (b % 10 > 1)
//{
//    k.Add(b);
//}
//for(int i = 0; i < f.Count; ++i)
//{
//    for(int j = 0; j < k.Count; ++j)
//    {
//        if (f[i] == k[j])
//        {
//           Console.WriteLine(f[i]+" ");
//        }
//    }
//}







//string textBox = Console.ReadLine();
//           int i = Convert.ToInt32(textBox);
//           textBox = Convert.ToString(i, 16);











































//int[] h = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
//           int[] a = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
//           int m=0, c=0;
//           for(int i = 0; i < h[0]-1; ++i)
//           {
//               if (a[i] + m <h[1])
//               {
//                   c++;
//                   m += a[i];
//               }
//           }
//           Console.WriteLine("{0} {1} ", c, m);
// 2 работа
//int g = int.Parse(Console.ReadLine());

//string j = Console.ReadLine();
//int l=0;
//string[] k = j.Split(' ');
//for (int i = 0; i < g; i++)
//{
//    l += int.Parse(k[i]);
//}

//Console.WriteLine(l);




// 3 работа

//int g = int.Parse(Console.ReadLine());
//string j = Console.ReadLine();
//int l = 0;
//string[] k = j.Split(' ');
//for (int i = 0; i < g; ++i)
//{
//    if (i % 2 == 0)
//    {
//        l += int.Parse(k[i]);
//    }
//    else
//    {
//        l -= int.Parse(k[i]);
//    }
//}
//Console.WriteLine(l);




// 4 работа

//int g = int.Parse(Console.ReadLine());
//if (g % 100 != 0 && g % 4 == 0 || g % 400 == 0)
//{
//    Console.WriteLine(1);
//}
//else Console.WriteLine(0);



// 6 работа

//double g = int.Parse(Console.ReadLine());
//double a = 0, w = 0, i = 0, b;
//a = g / 36;
//i = a % 36;
//w = g / 3;
//b = w % 3;


//Console.WriteLine(Math.Round(i) + " " + Math.Round(b));





//7 работа
//string number = Console.ReadLine();

//          int result = int.Parse(number);
//          int o = 0;
//          while (result >= 2)
//          {
//              if (result % 2 == 0)
//              {
//                  o++;
//              }
//              else
//              {
//                  break;
//              }
//              result = result / 2;
//          }
//          Console.WriteLine(o);

