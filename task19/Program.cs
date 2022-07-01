int GetReversedNumber(int number)
{
    int result = 0;
    while (number > 0)
    {
        int digit = number % 10;
        result = result * 10 + digit;
        number = number / 10;
    }
    return result;
}

void GetСheckPalindrom(int num1, int num2)
{
    if (num1 == num2)
    {
        Console.WriteLine("Число является пaлиндромом");
    }
    else
    {
        Console.WriteLine("Число не является пaлиндромом");
    }
}


Console.Write("Введите число для проверки:  ");
int number_test = Convert.ToInt32(Console.ReadLine());
int number_revers = GetReversedNumber(number_test);
GetСheckPalindrom(number_test, number_revers);