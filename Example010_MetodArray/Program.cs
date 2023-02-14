//Поиск значения в массиве и вывод его индекса
int[] array = { 51, 22, 33, 18, 24, 15, 36, 27, 18,};

int n = array.Length;
int find = 18;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;// останавливает выполнение . помогает если в искомых значений в массиве больше одного
    }
    index++;
}