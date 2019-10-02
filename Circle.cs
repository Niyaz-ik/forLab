using System;

namespace StepOne{
    public class Circle{
        public double area()
        {
            double R, S;
            const double Pi = 3.14;
            Console.WriteLine("Введите радиус");
            string input = Console.ReadLine();
            if(Double.TryParse(input, out R))
            {
                R = Convert.ToDouble(input);
            }
            else
            {
                return 0;
            }
            S = 4 * Pi * R*R;
            return S;
        }
        public double volume()
        {
            double R, V;
            const double Pi = 3.14;
            Console.WriteLine("Введите радиус");
            string input = Console.ReadLine();
            if(Double.TryParse(input, out R))
            {
                R = Convert.ToDouble(input);
            }
            else
            {
                return 0;
            }
            V = 4/3 * Pi * R*R*R;
            return V;
        }
    }
}