// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
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
}