void FilArray(int[] collection)//Описание метода, в котором происходит заполнение массива случайными числами
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)// Метод выводит в строк через пробел элементы массива
{
    int count = col.Length;
    int index = 0;
    while (index < count)
    {
        Console.Write($"{col[index]} ");
        index++;
    }
}

int IndexOff(int[] collection, int find)//Метод, который в заданном массиве ищет индекс элемента
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];//Описали массив array состоящий из 10 целых чисел. По умолчанию они равны 0.
FilArray(array);//Применяем метод FillArray к массиву array
PrintArray(array);//Применяем метод PrintArray к массиву array
Console.WriteLine();//Переводим курсор на новую строку
int pos = IndexOff(array, 4);// применяем метод IndexOff к массиву array, то есть ищем в нем элемент 4 и фиксируем его индех
Console.WriteLine(pos);// выводим найденный индекс на экран

