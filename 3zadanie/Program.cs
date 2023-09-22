int Vvod (string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int Akkerman(int m, int n)
{
    int result = m;
    if (m == 0)
    {
        return n + 1;
    }
    else 
    if (n == 0 && m > 0)
    {
        return Akkerman(m-1,1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
void VivodAkkerman(int m, int n)
{
    Console.Write(Akkerman(m,n));
}
int m = Vvod("Введите число m: ");
int n = Vvod("Введите число n: ");
VivodAkkerman(m,n);