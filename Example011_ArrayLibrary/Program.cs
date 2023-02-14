void FillArray(int[] collection)//определили массив из 10-ти элементов
//Наполнение массива случайными числами
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)//Вывел\распечатал массив в терминал
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // ставим -1 для того чтобы в случае отсутвия искомого значения выдавало не "0", т.к. индексу 0 присвоено значение в массиве, а -1. Тогда будет понятно что искомого значения в массиве нет. 
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

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);