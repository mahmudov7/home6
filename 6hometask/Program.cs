//task1
/* bool IsEven(int number)
{
    return number % 2 == 0;
}

Console.WriteLine(IsEven(4));   
Console.WriteLine(IsEven(7));   
Console.WriteLine(IsEven(0));   
Console.WriteLine(IsEven(-3));*/

//task2
/* int Max3(int a, int b, int c)
{
    int max = a;

    if (b > max)
    {
        max = b;
    }

    if (c > max)
    {
        max = c;
    }

    return max;
}

Console.WriteLine(Max3(5, 2, 9));
Console.WriteLine(Max3(-1, -5, -2));  
Console.WriteLine(Max3(3, 3, 3));    */  

//task3
/* int SumOfDigits(int number)
{
    int r = 0;
    int sum = 0;
    while(number > 0)
    {
        r = number % 10;
        number /= 10;
        sum += r;
    }
    return sum;
}
Console.WriteLine(SumOfDigits(1234)); */

//task4
/* bool IsPrime(int number)
{
    int cnt = 0;
    for (int i = 1; i <= number; i++)
    {
        if(number % i == 0)
        {
            cnt++;
        }
    }
    return cnt == 2;
}
Console.WriteLine(IsPrime(7)); */

//task5
/* int ReverseNumber(int number)
{
    int r = 0;

    while (number > 0)
    {
        int x = number % 10;
        r = r * 10 + x;
        number /= 10;
    }
    return r;
}

Console.WriteLine(ReverseNumber(1234)); */

//task6
/* int ReverseNumber(int number)
{
    int r = 0;

    while (number > 0)
    {
        int x = number % 10;
        r = r * 10 + x;
        number /= 10;
    }

    return r;
}

bool IsPalindrome(int number)
{
    return number == ReverseNumber(number);
}

Console.WriteLine(IsPalindrome(121));
Console.WriteLine(IsPalindrome(123)); */

//task7
/* int Factorial(int n)
{
    int r = 1;

    for (int i = 1; i <= n; i++)
    {
        r *= i;
    }

    return r;
}

Console.WriteLine(Factorial(0));
Console.WriteLine(Factorial(1));
Console.WriteLine(Factorial(5));
Console.WriteLine(Factorial(10)); */

//task8
/* int Power(int baseNumber, int exponent)
{
    int r = 1;

    for (int i = 0; i < exponent; i++)
    {
        r *= baseNumber;
    }

    return r;
}

Console.WriteLine(Power(2, 5));
Console.WriteLine(Power(3, 0));
Console.WriteLine(Power(5, 2)); */

//task9
/* double CelsiusToFahrenheit(double celsius)
{
    return celsius * 9 / 5 + 32;
}

Console.WriteLine(CelsiusToFahrenheit(0));
Console.WriteLine(CelsiusToFahrenheit(100));
Console.WriteLine(CelsiusToFahrenheit(-40));
Console.WriteLine(CelsiusToFahrenheit(37)); */

//task10
/* bool IsFaster(int time1, int time2)
{
    return time1 < time2;
}

Console.WriteLine(IsFaster(12, 15));
Console.WriteLine(IsFaster(20, 20));
Console.WriteLine(IsFaster(9, 11)); */