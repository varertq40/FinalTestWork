// Написать программу, которая их имеющегося массива строк формирует 
// массив из строк, длина которых меньше либо равна 3 символа. Первоначальный 
// массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2",":-)"]
// ["1234", "1567", "-2", "computer scince"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.Clear();

Console.WriteLine("Введите массив строк через пробел");
string inputValue = Console.ReadLine()!;
string[] firstArray;

firstArray = inputValue.Split(' ');
var secondArray = new string[firstArray.Length];

void SecondArray(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
    if(firstArray[i].Length <= 3)
        {
        secondArray[count] = firstArray[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(firstArray, secondArray);
PrintArray(secondArray);

