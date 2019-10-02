using System;

namespace StepOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0, temp;
            double x2 = 0, y2 = 0;
            bool state = true;
            bool flag = false;
            Console.WriteLine("Выберите дальнейшее действие \n");
            Console.WriteLine("1 - Использовать калькулятор \n");
            Console.WriteLine("2 - Чтение файла \n");
            Console.WriteLine("3 - Вычисление физических формул \n");
            Console.WriteLine("0 - Выход \n");
            temp = Convert.ToInt32(Console.ReadLine());
            if (temp == 1)
            {
                while (state){
                    Console.WriteLine("Введите первое число");
                    string input1 = Console.ReadLine();
                    Console.WriteLine("Введите второе число");
                    string input2 = Console.ReadLine();
                    if (Int32.TryParse(input1, out x) && Int32.TryParse(input2, out y))
                        {
                            x = Convert.ToInt32(input1);
                            y = Convert.ToInt32(input2); 
                            
                        }
                    else if (Double.TryParse(input1, out x2) && Double.TryParse(input2, out y2))
                            {
                                x2 = Convert.ToDouble(input1);
                                y2 = Convert.ToDouble(input2);
                                flag = true;
                            }
                    else{
                            Console.WriteLine("Некорректный ввод");
                            continue;
                        }
                       
                    Calculator calculator = new Calculator();
                    Console.WriteLine("Выберите действие \n");
                    Console.WriteLine("1) Сложение \n");
                    Console.WriteLine("2) Вычитание \n");
                    Console.WriteLine("3) Умножение \n");
                    Console.WriteLine("4) Деление \n");
                    Console.WriteLine("5) Остаток при делении \n");
                    Console.WriteLine("6) Возведение в степень \n");
                    Console.WriteLine("7) Добавить/вычесть процент от числа \n");
                    Console.WriteLine("0) Выход");
                    int CalTemp = Convert.ToInt16(Console.ReadLine());
                    switch(CalTemp)
                    {
                        case 1:
                        if(flag)
                        {
                            calculator.addition(x2, y2);
                        }
                        else{
                            calculator.addition(x, y);
                        }     
                        break;
                        case 2:
                        if(flag)
                        {
                            calculator.subtraction(x2, y2);
                        }
                        else{
                            calculator.subtraction(x, y);
                        }                            
                        break;
                        case 3:
                        if(flag)
                        {
                            calculator.multiplication(x2, y2);
                        }
                        else{
                            calculator.multiplication(x, y);
                        }                          
                        break;
                        case 4:
                        if(flag)
                        {
                            calculator.division(x2, y2);
                        }
                        else{
                            calculator.division(x, y);
                        }    
                        break; 
                        case 6:
                            if(flag)
                        {
                            calculator.exponentiation(x2, y2);
                        }
                        else{
                            calculator.exponentiation(x, y);
                        }     
                        break; 
                        case 5:
                        if(flag)
                        {
                            calculator.remainder(x2, y2);
                        }
                        else{
                            calculator.remainder(x, y);
                        }   
                        break;
                        case 7:
                            Console.WriteLine("Хотите добавить проценты или отнять?");
                            Console.WriteLine("1 - Добавить");
                            Console.WriteLine("Любое число - Отнять");
                            int tempStateForCase7 = Convert.ToInt16(Console.ReadLine());
                            if(tempStateForCase7 == 1)
                            {
                                if(flag)
                                {
                                    calculator.addInterest(x2, y2);
                                }
                                else{
                                    calculator.addInterest(x, y);
                                }   
                            }
                            else
                            {
                                if(flag)
                                {
                                    calculator.DivisionInterest(x2, y2);
                                }
                                else{
                                    calculator.DivisionInterest(x, y);
                                }   
                            }
                        break;
                        case 0:
                            Environment.Exit(0);
                        break;
                    }
                    Console.WriteLine("Ещё что-нибудь считать будем?");
                    Console.WriteLine("1 - Да");
                    Console.WriteLine("2 - Нет");
                    int tempState = Convert.ToInt16(Console.ReadLine());
                    if (tempState != 1)
                    {
                        state = false;
                    }
                }

            }
            else if(temp == 2)
            {
                Reader reader = new Reader();
                reader.read();
            }
            else if(temp == 3)
            {
                Physics physics = new Physics();
                Console.WriteLine("Выберите действие \n");
                Console.WriteLine("1) Найти путь \n");
                Console.WriteLine("2) Найти силу притяжения тела\n");
                int tempForPhysics = Convert.ToInt16(Console.ReadLine());
                switch(tempForPhysics)
                {
                    case 1:
                        Console.WriteLine("Путь = " + physics.ForArea() + "м");
                    break;
                    case 2:
                        Console.WriteLine("Сила притяжения = " + physics.forceOfGravity() + "Н");
                    break;
                }
            }
            else {
                Environment.Exit(0);
            }
            Console.WriteLine("Нажмите любую кнопку для выхода");
            Console.ReadLine();
        }
        
    }
}
