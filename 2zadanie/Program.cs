int Vvod (string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int Summ(int m, int n)
{
    int result = m;
    if (m == n)
    {
        return 0;
    }
    else
    {
        m++;
        result = m + Summ(m,n);
        return result;
    }
}
void SumText(int m, int n)
{
    Console.Write(Summ(m-1,n));
}
int m = Vvod("Введите число m: ");
int n = Vvod("Введите число n: ");
SumText(m,n);