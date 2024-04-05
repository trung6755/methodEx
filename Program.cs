using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodEx
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int i, pos, n; //pos la vi tri can xoa
            int[] arr1 = new int[50];


            Console.Write("\nXoa phan tu trong mang C#:\n");
            Console.Write("---------------------------\n");

            Console.Write("Nhap kich co mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            /* nhap cac phan tu vao trong mang*/
            Console.Write("Nhap {0} phan tu vao mang theo thu tu tang dan:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            remove(arr1);
            Console.ReadKey();
        }

        static int remove(int[] arr)
        {
            int pos, i;
            int n = 10;
            Console.Write("\nNhap vi tri can xoa: ");
            pos = Convert.ToInt32(Console.ReadLine());

            i = 0;
            while (i != pos - 1)
                i++;

            while (i < n)
            {
                arr[i] = arr[i + 1];
                i++;
            }
            n--;
            Console.Write("\nIn mang sau khi da xoa phan tu: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("  {0}", arr[i]);
            }
            Console.Write("\n\n");

            return i;
        }
        
    }
}
