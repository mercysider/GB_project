# gb_project

## Текстовое описание (алгоритм) работы программы

1. Введение исходного массива
Реализовано методом ArrayCreator(), с помощью которого пользователь сначала вводит размерность массива, а затем заполняет массив строковыми элементами с клавиатуры.
```csharp
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
```
2. Получение результирующего массива
Реализовано методом ArrayShortCreator(string[] array), который в качестве параметра получает исходный массив и создает новый массив размерностью исходного. Затем отбирает в новый массив только элементы, удовлетворяющие условию, а в конце образает получившийся массив до нужной размерностью с помощью системного метода Array.Resize, т.е. по сути оставляет новый массив с нужными элемнтами.
```csharp
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
```
3. Вывод исходного и результирующего массива в консоль
Реализовано методом ArrayPrint(string[] matrix), который в качестве параметра получает массив и поэлементно выводит его в консоль. Также добавлен вывод квадртаных скобок, обрамляющих массив для большей наглядности.
```csharp
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
```
4. Основной код программы выглядит следующим образом:
```csharp
string[] array = ArrayCreator();
string[] shortarray = ShortArrayCreator(array);
ArrayPrint(array);
ArrayPrint(shortarray);
```
