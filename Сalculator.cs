using System;
/// <summary>  
///  Класс калькулятора с методами.  
/// </summary>  
public class Calculator {
    private int result = 0;
    private bool errorForTest = true;
    private double resultForDouble = 0;
    /// <summary>
    /// Метод для сложения двух целых чисел. 
    /// </summary>
    /// <param name="x">Первая переменная.</param>
    /// <param name="y">Вторая переменная.</param>
    public void addition (int x, int y)
    {
        result = x + y;
        Rez();
        
    }
    /// <summary>
    /// Метод для сложения двух десятичных чисел. 
    /// </summary>
    /// <param name="x">Первая переменная.</param>
    /// <param name="y">Вторая переменная.</param>
    public void addition (double x, double y)
    {
        resultForDouble = x + y;
        Rez2();
    }
    /// <summary>
    /// Метод для вычитания двух целых чисел. 
    /// </summary>
    /// <param name="x">Первая переменная.</param>
    /// <param name="y">Вторая переменная.</param>
    public void subtraction(int x, int y)
    {
        result = x - y;
        Rez();
    
    }
    /// <summary>
    /// Метод для вычитания двух десятичных чисел. 
    /// </summary>
    /// <param name="x">Первая переменная.</param>
    /// <param name="y">Вторая переменная.</param>
    public void subtraction(double x, double y)
    {
        resultForDouble = x - y;
        Rez2();
    
    }
    /// <summary>
    /// Метод для перемножения двух целых чисел. 
    /// </summary>
    /// <param name="x">Первая переменная.</param>
    /// <param name="y">Вторая переменная.</param>
    public void multiplication(int x, int y)
    {
        
        result = x * y;
        Rez();
    }
    /// <summary>
    /// Метод для перемножения двух десятичных чисел. 
    /// </summary>
    /// <param name="x">Первая переменная.</param>
    /// <param name="y">Вторая переменная.</param>
    public void multiplication(double x, double y)
    {
        
        resultForDouble = x * y;
        Rez2();
    }
    /// <summary>
    /// Метод для деления двух целых чисел. 
    /// </summary>
    /// <param name="x">Первая переменная.</param>
    /// <param name="y">Вторая переменная.</param>
    public void division(int x, int y)
    {
        double tempX, tempY;
        try
        {
            int error = x / y;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Деление на 0 запрещено!!!\n");
            errorForTest = false;
            return;
        }
            tempX = Convert.ToDouble(x);
            tempY = Convert.ToDouble(y);
            resultForDouble = tempX / tempY;
            Rez2();
     }
    /// <summary>
    /// Метод для деления двух десятичных чисел. 
    /// </summary>
    /// <param name="x">Первая переменная.</param>
    /// <param name="y">Вторая переменная.</param>
    public void division(double x, double y)
    {
        if(y == 0)
        {
            Console.WriteLine("Ошибка при делении - нельзя делить на ноль!");
            errorForTest = false;
            return;
        }
        resultForDouble = x / y;
        Rez2();
    }
    /// <summary>
    /// Метод для возведения первого числа в степень равную второму. 
    /// </summary>
    /// <param name="x">Первая переменная.</param>
    /// <param name="y">Вторая переменная.</param>
    public void exponentiation(int x, int y)
    {
        resultForDouble = Math.Pow(x, y);
        Rez2();
    }
    public void exponentiation(double x, double y)
    {
        resultForDouble = Math.Pow(x, y);
        Rez2();
    }
    /// <summary>
    /// Метод находит остаток от деления двух целых чисел. 
    /// </summary>
    /// <param name="x">Первая переменная.</param>
    /// <param name="y">Вторая переменная.</param>
    public void remainder(int x, int y)
    {
        resultForDouble = x % y;
        Rez2();
    }
    public void remainder(double x, double y)
    {
        resultForDouble = x % y;
        Rez2();
    }
    /// <summary>
    /// Метод для добавления к первому числу проценты равные второму. 
    /// </summary>
    /// <param name="x">Первая переменная.</param>
    /// <param name="y">Вторая переменная.</param>
    public void addInterest(int x, int y)
    {
        double tempX, tempY;
        tempX = Convert.ToDouble(x);
        tempY = Convert.ToDouble(y);
        resultForDouble = tempX + (tempX * tempY / 100);
        Rez2();
    }
    public void addInterest(double x, double y)
    {
        resultForDouble = x + (x * y / 100);
        Rez2();
    }
    /// <summary>
    /// Метод для вычитания от первого числу проценты равные второму. 
    /// </summary>
    /// <param name="x">Первая переменная.</param>
    /// <param name="y">Вторая переменная.</param>
    public void DivisionInterest(int x,int y)
    {
        double tempX, tempY;
        tempX = Convert.ToDouble(x);
        tempY = Convert.ToDouble(y);
        resultForDouble = tempX - (tempX * tempY / 100);
        Rez2();
    }
    public double ForArea(double x, double y)
    {
        double S, v, t;
        v = x;
        t = y;
        S = v * t;
        return S;
    }
     public int ForArea(int x, int y)
    {
        int S, v, t;
        v = x;
        t = y;
        S = v * t;
        return S;
    }
    public void DivisionInterest(double x, double y)
    {
        resultForDouble = x - (x * y / 100);
        Rez2();
    }
    public double diffF(double x, double y)
    {
        double F1, F2, m, res;
        const double g = 9.82;
        m = x;
        F1 = g * m;
        m = y;
        F2 = g * m;
        res = F1 - F2;
        if(res < 0)
        {
            res *= -1;
        }
        return res;
    }
    public double diffF(int x, int y)
    {
        double F1, F2, m, res;
        const double g = 9.82;
        m = Convert.ToDouble(x);
        F1 = g * m;
        m = Convert.ToDouble(y);
        F2 = g * m;
        res = F1 - F2;
        if(res < 0)
        {
            res *= -1;
        }
        return res;
    }
    private void Rez()
    {
        Console.WriteLine("Результат : " + result);
    }
    private void Rez2()
    {
        Console.WriteLine("Результат : " + resultForDouble);
    }
    public double GetDouble()
    {
        return resultForDouble;        
    }
    public int GetInt()
    {
        return result;        
    }
    public bool ErrorForTest()
    {
        return errorForTest;
    }
}