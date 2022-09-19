// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

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