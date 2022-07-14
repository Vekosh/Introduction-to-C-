void FillArray(int[] collection)// collection - аргумент

{
    int length = collection.Length; // получаем длиyну  массива .Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);// даем числу рандомное значение
        index++;
    }
}

void PrintArray(int[] col)// печвтает массив
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // вводим новый массив

FillArray(array); // даёт рандом, МЕТОД ЗАПОЛНИЛ НАШ МАССИВ
PrintArray(array);// выводит одни нули, МЕТОД ВЫВЕЛ НАШ МАССИВ НА КОНСОЛЬ
Console.WriteLine();

int pos = IndexOf(array, 4); // переменная pos, результат работы метода IndexOf
Console.WriteLine(pos);