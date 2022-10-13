using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        //arry
        private int[] a = new int [20];

        //var
        private int n;

        //method
        public void read()
        {
            //menerima data
            while(true)
            {
                Console.Write("Masukkan Banyaknya Nomor: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nmempunyai maksimal 20 nomor.\n");
            }
            while (true)
            {
                Console.Write("Masukkan Banyaknya Nama: ");
                string s = Console.ReadLine();
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nmempunyai maksimal 20 jumlah nama.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("          Masukkan Nomor          ");

            // memasukkan 
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("          Masukkan Nama          ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s2 = Console.ReadLine();
            }
        }

        public void display()
        {
            // menampilkan
            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("      Data Nomor dan Nama         ");
            Console.WriteLine("----------------------------------");
            for (int j = 0; j < n; j++)
            {   
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
        }

        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    if (a[j] < a[i])
                    {
                        int temp;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Program myList = new Program();
            //panggil fungsi
            myList.read();

            myList.BubbleSortArray();

            myList.display();

            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar.");
            Console.Read();
        }
    }
}













   










