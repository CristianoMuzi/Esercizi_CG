static double Fattoriale(int number)
{
    double factorial = number;
    for (int i = 1; i < number; i++)
    {
        factorial *= i;
    }
    return factorial;
}