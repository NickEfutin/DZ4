 Console.WriteLine ("Дай мне три числа");
  int number1 = Convert.ToInt32 (Console.ReadLine());
  int number2 = Convert.ToInt32 (Console.ReadLine());
  int number3 = Convert.ToInt32 (Console.ReadLine());
            
    if (number1 > number2 && number1 > number3)
        Console.WriteLine("Nubmer Max = " + number1); 
    else if (number2 > number3)
        Console.WriteLine("Number Max = " + number2); 
    else
        Console.WriteLine("Number Max = " + number3); 
                  