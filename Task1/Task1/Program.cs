// Task 1
int num = 54321;
int reverse = 0;



while (num != 0)
{
    reverse = reverse * 10;
    reverse = reverse + num % 10;
    num = num / 10;
}
Console.WriteLine(reverse);

