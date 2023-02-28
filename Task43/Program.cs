void Point (double[] arr)
{
    if (arr[2] == arr[3])
    {
        Console.WriteLine ("Прямые параллельны");
    }
    else
    {
        double x = Math.Round ((arr[1]-arr[0]) / (arr[2]-arr[3]), 2);
        double y = 5*x+2;
        Console.WriteLine ($"Точка пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2 равна ({x}; {y})");
    }
}

void FillArray (double[] mas)
{
    Console.WriteLine ("Введите b1, b2, k1, k2");
    for (int i = 0; i < 4; i++)
    {
        mas[i] = Convert.ToDouble(Console.ReadLine());
    }
}

double [] array = new double[4];
FillArray (array);
Point (array);