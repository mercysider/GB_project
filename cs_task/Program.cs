string[] ArrayCreator()
{
    Console.WriteLine("Введите кол-во элементов массива:");
    int intSize = int.Parse(Console.ReadLine()!);

    string[] matrix = new string[intSize];
      
    for (int i = 0; i < matrix.Length; i++)
    {
        Console.WriteLine($"Введите элемент массива номер {i+1}");
        string nextElement = Console.ReadLine();
        matrix[i] = nextElement;
    }
    return matrix;
}

void ArrayPrint(string[] matrix)
{
    Console.WriteLine($"Элементы массива ({matrix.Length}): ");
    if (matrix.Length > 0)
    {
        Console.Write("[");
        for (int i = 0; i < matrix.Length-1; i++)
        {
            Console.Write($"{matrix[i]}, ");
        } 
        Console.WriteLine($"{matrix[matrix.Length-1]}]");
    }
    else Console.WriteLine("[]");                   
}

string[] ShortArrayCreator(string[] array)
{
    string[] matrix = new string[array.Length];
    int j = 0;  
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            matrix[j] = array[i];
            j++;
        } 
    }
    Array.Resize(ref matrix, j);
    return matrix;
}

string[] array = ArrayCreator();
string[] shortarray = ShortArrayCreator(array);
ArrayPrint(array);
ArrayPrint(shortarray);