// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] myArray = {1, 2, 5, 0, 10, 34};

// Решение задачи

void ConvertArray(int[] array, int i)
{
    if (i >= 0)
    {
            Console.Write(array[i] + " ");
            ConvertArray(array, i - 1);
    }
}
ConvertArray(myArray, myArray.Length - 1);