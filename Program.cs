using System;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            int numOfStudents = 500_000;

            var startTime = DateTime.Now;

            School school = new School();
            for (int i = 0; i < numOfStudents; i++)
            {
                school.Students.Add(new student
                    {
                        number = (uint)i,
                        countPhone = (uint)RandomAmountOfPhones(r),
                        countLunch = (uint)RandomAmountOfLunches(r),
                        position = (Position)RandomPosition(r),
                    });
            }

            (student min, student max) minAndMax = school.FindExtremumStudents();
            Console.WriteLine($"Лучший ученик сделал {minAndMax.max.countPhone} " +
                $"телефонов, у него {minAndMax.max.countLunch} порций обеда. " +
                $"Серийный номер ученика: {minAndMax.max.number}");

            Console.WriteLine($"Худший ученик сделал {minAndMax.min.countPhone} телефонов, " +
                $"у него {minAndMax.min.countLunch} порций обеда. " +
                $"Серийный номер ученика: {minAndMax.min.number}");
            
            Console.WriteLine($"\n ***Время выполнения программы: {(DateTime.Now - startTime).TotalSeconds} " +
                $"екунд.***");
        }

        static int RandomAmountOfPhones(Random r)
        {
            double seed = r.NextDouble();
            int res = 0;
            if (seed < 0.1)
            {
                res = r.Next(1, 250_000);
            }
            else if (seed < 0.9)
            {
                res = r.Next(25_000, 750_000);
            }
            else
            {
                res = r.Next(75_000, 1000_000);
            }
            return res;
        }

        static int RandomAmountOfLunches(Random r)
        {
            return r.Next(2, 7);
        }

        static int RandomPosition(Random r)
        {
            return r.Next(0, 4);
        }
    }
}
