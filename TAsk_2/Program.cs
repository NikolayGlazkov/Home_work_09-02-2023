// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

Console.WriteLine("Введите число m, количество строк");
int m = 5;//int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n, количество столбцов");
int n = 5;//int.Parse(Console.ReadLine());

double[,] array = new double[m, n]; // двумерный массив


for (int i = 0; i < m; i++) //заполняем массив рандомом
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Массив после сортировки:");

for (int i = 0; i < m; i++) //перебераем каждую строку (наружний массив)
{
    double[] row = new double[n];
    for (int j = 0; j < n; j++) //перебераем элемент в каждой строке
    {
        row[j] = array[i, j]; //временный ассив, который используется для хранения элементов текущей строки двумерного массива
    }

    Array.Sort(row, (x, y) => y.CompareTo(x)); //строка чисто из интеренета каюсь :( метод Array.Sort сортерует временный массив row  в порядке убывания; если поменять местами x и y в y.CompareTo(x) сортирует в порядке возростания.

    for (int j = 0; j < n; j++) //перезапись элементов в масив
    {
        array[i, j] = row[j];
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
