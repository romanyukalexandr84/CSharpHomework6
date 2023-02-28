void FillArray (int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.WriteLine ($"Введите {i+1}-е число");
        mas[i] = Convert.ToInt32(Console.ReadLine());
    }
}
 
 void PrintArray (int[] arr)
{
    for (int j = 0; j < arr.Length; j++)
    {
        Console.Write(arr[j] + " ");
    }
}

 int AboveZero (int[] massiv)
{
    int count = 0;
    for (int k = 0; k < massiv.Length; k++)
    {
        if (massiv[k] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine ("Сколько чисел будете вводить?");
int m = Convert.ToInt32(Console.ReadLine());

int [] array = new int[m];

FillArray (array);
Console.WriteLine ();

PrintArray (array);
Console.WriteLine ();

Console.WriteLine ("Количество введенных чисел больше 0 = "+AboveZero(array));
