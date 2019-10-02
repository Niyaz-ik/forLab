using System;

namespace StepOne{
    public class Physics{
    public double ForArea()
    {
        double S, v, t;
        Console.WriteLine("Введите скорость \n");
        string input = Console.ReadLine();
        Console.WriteLine("Введите время\n");
        string input2 = Console.ReadLine();
        if(Double.TryParse(input, out v) && Double.TryParse(input2, out t))
        {
            v = Convert.ToDouble(input);
            t = Convert.ToDouble(input2);
        }
        else
        {
            return 0;
        }
        S = v * t;
        return S;
    }
   /*  public int ForArea(int x, int y)
    {
        int S, v, t;
        v = x;
        t = y;
        S = v * t;
        return S;
    }*/
    public double forceOfGravity()
    {
        double F, m;
        const double g = 9.82;
        Console.WriteLine("Введите массу");
        string input = Console.ReadLine();
        if(Double.TryParse(input, out m))
        {
            m = Convert.ToDouble(input);
        }
        else
        {
            return 0;
        }
        F = g * m;
        return F;
    }
   

    }
}