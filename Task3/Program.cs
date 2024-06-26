﻿// Задача 3
// Обнулить все чётные элементы массива

void ZeroEvenElements(int[] arr) // ввод функции обращения к массиву
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void PrintArray(int[] arr) // ввод функции нового массива с нужным результатом (для вывода)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}

int[] array = { 1, 2, 3, 4, 5 }; // создание целочисленного массива (для выполнения условия)

// Создание функции с передачей в неё этого целочисленного массива:
ZeroEvenElements(array);

// Создание функции для вывода изменённого массива по условию:
PrintArray(array);
