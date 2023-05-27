using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap gia tri canh a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap gia tri canh b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int cv = (a + b) * 2;
            Console.WriteLine("Chu vi hinh chu nhat = " + cv);
            int dt = a * b;
            Console.WriteLine("Dien tich hinh chu nhat = " + dt);
            Console.ReadKey();
        }
    }
}
