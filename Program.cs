// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// На этой ветке создадим метод для заполнения массива



void FillUserArray (string [] userArray)
{
    int length = userArray.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write ($"Введите {i+1}-й элемент массива: ");
        userArray [i] = Console.ReadLine();
    }
// На этой ветке создаем метод для вывода элементов массива


void PrintArray (string [] printArray)
{
    int length = printArray.Length;
    Console.Write ("[");
    for (int i = 0; i < length-1; i++)
    {
        Console.Write (printArray[i]+", ");
    }
    Console.Write ($"{printArray[length-1]}]");
// На этой ветке будем создавать основной алгоритм


string [] ChangeArray (string [] enterArray)
{
    int changeSize = 0;
    int length = enterArray.Length;
    for (int i = 0; i < length; i++)
    {
        if (enterArray[i].Length <= 3)
        {
            changeSize++;
        }
    }
    if (changeSize == 0)
    {        
        string [] printArray = new string [] {"В массиве отсутствуют элементы длиной меньше или равной 3 символам"};

        return (printArray);
    }
    else
    {
        string [] printArray = new string [changeSize];
        int count = 0;
        for (int i = 0; i < changeSize; i++)
        {
            for (int j = count; j < length; j++)
            {
                if (enterArray[j].Length <= 3)
                {   
                    printArray[i] = enterArray[j];
                    count = j+1;
                    break;
                }
            } 
        }
        Console.WriteLine ("Массив с элементами длиной меньше или равной 3 символам:");
        return (printArray);
    }

Console.WriteLine("Из входного массива строк я сформирую массив, длина элементов которого больше трех символов");
Console.WriteLine("Для начала определим, какой массив будем использовать");
        repeatEnter:
Console.WriteLine("Введите 1, если хотет использовать мой массив из глаголов длиной в 5 элементов");
Console.WriteLine("Введите 2, если хотите ввести массив вручную");
int input = Convert.ToInt16 (Console.ReadLine());
Console.WriteLine ();

switch (input)
{
    case 1:
    string [] arrayFix = new string [] {"cut", "go","paste", "be", "understand"};
    Console.WriteLine ("Вот мой массив:");
    PrintArray (arrayFix);
    Console.WriteLine ();
    string [] finalArrayFromFix = ChangeArray (arrayFix);
    PrintArray (finalArrayFromFix);
    break;

    case 2:
    Console.Write("Введите количество элементов массива: ");
    int quantityElements = Convert.ToInt16 (Console.ReadLine());
    string [] arrayUser = new string [quantityElements];
    FillUserArray (arrayUser);
    Console.WriteLine ();
    Console.WriteLine ("Вот Ваш массив:");
    PrintArray (arrayUser);
    Console.WriteLine (); 
    string [] finalArrayFromUser = ChangeArray (arrayUser);
    PrintArray (finalArrayFromUser);
    break;

    default:
    Console.WriteLine ("Неверный ввод!");
    goto repeatEnter;
}

        repeatAnswer:
Console.WriteLine();    
Console.WriteLine("Желаете выполнить новую задачу? Y/N");
string answer = Console.ReadLine();
switch (answer.ToLower())
{
    case "y":
    goto repeatEnter;

    case "n":
    Console.WriteLine("Задача завершена. Спасибо!");
    break;

    default:
    Console.WriteLine("Ошибка ввода!");
    goto repeatAnswer;
}