int Vvod (string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void NaturalLow(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        NaturalLow(n, count + 1);
        Console.Write(count + " ");
    }
}
int count = 1;
int number = Vvod("Введите число: ");
NaturalLow(number, count);