using System;

namespace Lab2_Students_
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstract_Student[] mass = new Abstract_Student[] { new Student1(), new Student2(), new Student3() };
            Console.WriteLine(@"Что бы узнать информацию о студентах, введите: 
                0 - все студенты
                1 - студент 1 
                2 - студент 2 
                3 - студент 3");
            char s = Convert.ToChar(Console.ReadLine());

            switch (s)
            {
                case '0':
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine(mass[i].Student_name());
                        Console.WriteLine(mass[i].Namber_());
                        Console.WriteLine(mass[i].Direction_());
                        Console.WriteLine(mass[i].Form_());
                        Console.WriteLine(mass[i].Years_());
                        Console.WriteLine();
                    }
                    break;
                case '1':
                    Console.WriteLine(mass[0].Student_name());
                    Console.WriteLine(mass[0].Namber_());
                    Console.WriteLine(mass[0].Direction_());
                    Console.WriteLine(mass[0].Form_());
                    Console.WriteLine(mass[0].Years_());

                    Console.WriteLine();
                    break;
                case '2':
                    Console.WriteLine(mass[1].Student_name());
                    Console.WriteLine(mass[1].Namber_());
                    Console.WriteLine(mass[1].Direction_());
                    Console.WriteLine(mass[1].Form_());
                    Console.WriteLine(mass[1].Years_());
                    Console.WriteLine();
                    break;
                case '3':
                    Console.WriteLine(mass[2].Student_name());
                    Console.WriteLine(mass[2].Namber_());
                    Console.WriteLine(mass[3].Direction_());
                    Console.WriteLine(mass[3].Form_());
                    Console.WriteLine(mass[3].Years_());
                    Console.WriteLine();
                    break;

                 default:
                    Console.WriteLine("Нет студента с таким номером!");
                    break;
            }
        }
    } 
}
