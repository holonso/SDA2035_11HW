using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA2035_11HW
{
    class Program
    {
        static void Main(string[] args)
        {
            LinUr linur = new LinUr { k = 3, b = 1 }; // Экземпляр структуры
            linur.Root(); // Вызов метода
            Console.ReadKey();
        }
        struct LinUr // Структура
        {
            public double k; // Поля k и b вещественного типа
            public double b;
            public void Root() // Метод
            {
                Console.WriteLine("x = {0:F3}", (-b / k)); // 0=kx+b это x=(-b/k)
            }
        }
    }
}
