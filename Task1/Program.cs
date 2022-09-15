// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив
// из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно 
// ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не 
// рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → [] 

Console.Write("Введите количество элементов массива: ");
int sizeStartArray = Convert.ToInt32(Console.ReadLine());
string[] startArray = new string[sizeStartArray];
int sizeFinishArray = 0;
for (int i = 0; i < sizeStartArray; i++)
{
    Console.Write($"Введите {i + 1}й элемент массива: ");
    startArray[i] = Console.ReadLine();
    if (startArray[i].Length <= 3) sizeFinishArray++;
}
string[] finishArray = new string[sizeFinishArray];
int count = 0;
for (int i = 0; i < sizeStartArray; i++)
{
    if (startArray[i].Length <= 3)
    {
        finishArray[count] = startArray[i];
        count++;
    }
}
Console.WriteLine();
Console.Write($"[{String.Join(", ", startArray)}]->");
Console.WriteLine($"[{String.Join(", ", finishArray)}]");