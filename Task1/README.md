## Условия задачи
 *Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*

### Примеры:
* [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
* [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
* [“Russia”, “Denmark”, “Kazan”] → []

## Решение.

Решение задачи можно разбить на три блока.
1. Блок: ввод размера входящего массива, ввод входящего массива в цикле и получение размера исходящего массива.

```
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
```

2. Блок: получение исходящего массива перебором в цикле.

```
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
```
3. Блок: вывод входящего и исходящего массива.

```
Console.WriteLine();
Console.Write($"[{String.Join(", ", startArray)}]->");
Console.WriteLine($"[{String.Join(", ", finishArray)}]");
```

## Результат работы программы:
![Скрин терминала:](/Task1/ScreenTerminal.jpg)