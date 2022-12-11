// Напишите цикл, который принимает 
//на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число A.");

int a = Convert.ToInt32(Console.ReadLine());
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Введите число больше 0.");
        }
    }

    return result;
}
int GetDegree( int b)
{
       int result = 1;
    for (int i = 1; i <= b; i++ )
      {
        result = result * a;  
    }  
    return result; 
}
     int b = GetNumber("Введите число В больше 0:");
      int result = GetDegree( b);
      Console.WriteLine($"A в спепени В  = {result}");


