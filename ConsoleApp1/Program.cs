using System;
using ClassLibrary3;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Введите затраченное время");// ввод пользователем
            int time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите оклад");// ввод пользователем
            int salary = Convert.ToInt32(Console.ReadLine());


            int s = Class1.wages(time, salary);
            Console.WriteLine($"Зарплата = {s}");//вывод в консоль


            //2
            Console.WriteLine("Вторая задача. Введите затраченное время");// ввод пользователем
            int Time = Convert.ToInt32(Console.ReadLine());

            int Z = Class1.office_equipment(Time);
            Console.WriteLine($"Затраты = {Z}Р");//вывод в консоль

            //3
            Console.WriteLine("3 задача. Введите время работы над продутком");// ввод пользователем
            int t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите тариф электроэнергии в руб");// ввод пользователем
            double rate = Convert.ToDouble(Console.ReadLine());

            int E = Class1.electricity(t, rate);

            Console.WriteLine($"Затраты на электроэнергию = {E}");//вывод в консоль


            //4
            Console.WriteLine("Введите аммортизацию");// ввод пользователем
            int cost = Convert.ToInt32(Console.ReadLine());
            int A = Class1.depreciation(cost);
            Console.WriteLine(A);//вывод в консоль


            //5
            Console.WriteLine("Введите спец продукты");
            int specialProducts = Convert.ToInt32(Console.ReadLine()); //ввод пользователем

            int result = Class1.cost_calculation(s,Z,E,A, specialProducts);// подсчет итогового результата
            Console.WriteLine($"Результат выполенных работ = {result}");//вывод в консоль




            Console.ReadKey();







        }
    }
}
