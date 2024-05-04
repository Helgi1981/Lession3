// Задача №2

// Вывод на экран квадратов чисел от 1 до N. 

// Создание функции:
// 1. Что делает функция?
// 2. Какие данные ей нужны для работы?
// 3. Что будет результатом работы?

void PrintSquares(int limit)
{
    int i = 1;
    while (i <= limit)
    {
        Console.Write($"{i * i} ");
        i++; // i = i + 1;
    }
}

PrintSquares(5);
PrintSquares(10);
PrintSquares(15);
