// // 1. Заполнить двумерный массив размером n*m случайными числами
void FillMatrix(int[,] matrixArray)
{
    for (int i = 0; i < matrixArray.GetLength(0); i++)
    {
        for (int j = 0; j < matrixArray.GetLength(1); j++)
        {
            matrixArray[i, j] = new Random().Next(0, 11);
        }
    }
    // return matrixArray;
}

// // 2. Напечатать двумерный массив на экран
void PrintMatrix(int[,] matrixArray)
{
    for (int i = 0; i < matrixArray.GetLength(0); i++)
    {
        for (int j = 0; j < matrixArray.GetLength(1); j++)
        {
            System.Console.Write($" {matrixArray[i, j]}");
        }
        System.Console.WriteLine();
    }
}



// Найти произведение побочной диагонали матрицы
System.Console.WriteLine("Задача 1: Найти произведение побочной диагонали матрицы");
int[,] matrixArray = new int[3, 3];
FillMatrix(matrixArray);
PrintMatrix(matrixArray);

int FindProductOfSecondaryDiagonalElements (int [,] matrixArray)
{
    int productOfSecondaryDiagonalElements = 1;
    int lastColumnIndex = matrixArray.GetLength(1) - 1;
    for (int i = 0; i < matrixArray.GetLength(0); i++)
    {
        productOfSecondaryDiagonalElements = productOfSecondaryDiagonalElements * matrixArray[i,lastColumnIndex];
        lastColumnIndex--;   
    }
    return productOfSecondaryDiagonalElements;
}

FindProductOfSecondaryDiagonalElements(matrixArray);
System.Console.WriteLine($"Произведение элементов побочной диагонали матрицы = {FindProductOfSecondaryDiagonalElements(matrixArray)}");



// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

System.Console.WriteLine();
System.Threading.Thread.Sleep(5000);
System.Console.WriteLine("Задача 2: В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет");

int RequestUserNumber()
{
    System.Console.WriteLine("Введите число");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}

void FindAndShowNumberPositions (int [,] arrayMatrix, int userNumber)

{   
    int count = 0;
    for (int i = 0; i < arrayMatrix.GetLength(0); i++)
    {
        for (int j = 0; j<arrayMatrix.GetLength(1); j++)
        {
            if (arrayMatrix[i,j] == userNumber) 
            {
                System.Console.WriteLine($"Строка #{i+1}, столбец #{j+1}");
            }
            else
            {
                count++;
            }
            if (count==arrayMatrix.GetLength(0)*arrayMatrix.GetLength(1))
            {
                System.Console.WriteLine("такого числа нет в таблице");
            }
        }
    }
}


int[,] matrixArray50 = new int[6, 5];
FillMatrix(matrixArray50);
PrintMatrix(matrixArray50);
int userNumber = RequestUserNumber();
FindAndShowNumberPositions(matrixArray50, userNumber);




// 54. В матрице чисел найти сумму элементов главной диагонали // !!!
System.Console.WriteLine();
System.Threading.Thread.Sleep(70000);
System.Console.WriteLine("Задача 3: В матрице чисел найти сумму элементов главной диагонали");
// первый способ

int[,] matrixArray54 = new int[3, 3];

int SumDiagEl(int[,] array)
{
    int sumDiagEl = 0;
    for (int i = 0; i < matrixArray.GetLength(0); i++)
    {
        for (int j = 0; j < matrixArray.GetLength(1); j++)
        {
            if (i == j)
            {
                sumDiagEl = sumDiagEl + matrixArray[i, j];
            }
        }
    }
    return sumDiagEl;
}

//второй способ
int SumDiagEl2(int[,] array)
{
    int sumDiagEl2 = 0;
    for (int i = 0; i < matrixArray.GetLength(0); i++)
    {
        sumDiagEl2 = sumDiagEl2 + matrixArray[i, i];
    }
    return sumDiagEl2;
}

//применение методов
FillMatrix(matrixArray54);
PrintMatrix(matrixArray54);
System.Console.WriteLine($"способ 1 сумма элементов главной диагонали={SumDiagEl(matrixArray54)}");
System.Console.WriteLine($"способ 2 сумма элементов главной диагонали={SumDiagEl2(matrixArray54)}");



// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
System.Console.WriteLine();
System.Threading.Thread.Sleep(10000);
System.Console.WriteLine("Задача 4: Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов");

void FindAverColumnAndShow(int[,] matrixArray)
{
    int j = 0;
    int i = 0;
    int arrayAverEveryColumn = 0;
    int arrayAverEveryColumnSum = 0;
    int countOfColumn = 1;
    while ((j < matrixArray.GetLength(1)) && (i < matrixArray.GetLength(0)))
    {
        arrayAverEveryColumnSum = arrayAverEveryColumnSum + matrixArray[i, j];
        i++;
        if (i == matrixArray.GetLength(0))
        {

            arrayAverEveryColumn = arrayAverEveryColumnSum / (matrixArray.GetLength(0));
            System.Console.WriteLine($"среднее арифметическое столбца №{countOfColumn} = {arrayAverEveryColumn}");
            j++;
            countOfColumn++;
            i = 0;
            arrayAverEveryColumnSum=0;
        }                 
    }
}

int[,] matrixArray55 = new int[3, 6];
FillMatrix(matrixArray55);
PrintMatrix(matrixArray55);
FindAverColumnAndShow(matrixArray55);



// // 56. Написать программу, которая обменивает элементы первой строки и последней строки
System.Console.WriteLine();
System.Threading.Thread.Sleep(10000);
System.Console.WriteLine("Задача 56: Написать программу, которая обменивает элементы первой строки и последней строки");
int[,] matrixArray56 = new int[5, 10];
FillMatrix(matrixArray56);
PrintMatrix(matrixArray56);

int[,] ReplaceFirstAndLastRows(int[,] matrixArray)
{
    for (int i = 0; i < matrixArray.GetLength(0); i++)
    {
        for (int j = 0; j < matrixArray.GetLength(1); j++)
        {
            int lastRowIndex = matrixArray.GetLength(0)-1;
            int temporaryRowEl = 0;
            if (i == 0)
            {
                temporaryRowEl = matrixArray[0,j];
                matrixArray[i, j] = matrixArray[lastRowIndex, j];
                matrixArray[lastRowIndex, j] = temporaryRowEl;
            }
        }
    }
    return matrixArray;
}
System.Console.WriteLine("замененный массив");
PrintMatrix(ReplaceFirstAndLastRows(matrixArray56));
