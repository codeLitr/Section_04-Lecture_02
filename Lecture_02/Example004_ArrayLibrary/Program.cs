//Void - метод, который не возвращает значение, т.е. команда return не применяется

/*
void FillArray(int[] collection) //Создается метод по заполнению нового массива, т.к. при создании нового массива все элементы в нем с нулевыми значениями
{
    int length = collection.Length; //Определяется длина (размер) массива
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10); //При создании нового массива он наполнен нулями, в данном случае мы создали массив из десяти элементов и чтобы придать всем элементами какие-то значения, присваиваем случайные значения всем элементам по очереди
        index++;
    }
}

void PrintArray(int[] col) // Создается метод, который будет печатать массив, при этом у всех аргументов и переменных меняем названия
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]); //Выведет на экран значение на текущей позиции 
        position++;
    }
}

int [] array = new int [10]; // Создает новый массив, в котором будет 10 элементов

FillArray(array);
PrintArray(array);
*/

/*
Нахождение позиции элемента в массиве с использованием Void методов
*/
void FillArray(int[] collection) //Создается метод по заполнению нового массива, т.к. при создании нового массива все элементы в нем с нулевыми значениями
{
    int length = collection.Length; //Определяется длина (размер) массива
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10); //При создании нового массива он наполнен нулями, в данном случае мы создали массив из десяти элементов и чтобы придать всем элементами какие-то значения, присваиваем случайные значения всем элементам по очереди
        index++;
    }
}

void PrintArray(int[] col) // Создается метод, который будет печатать массив, при этом у всех аргументов и переменных меняем названия
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]); //Выведет на экран значение на текущей позиции 
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //Если искомого значение нет в массиве, то будет выводиться -1

    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++; 
    }
    return position;
}

int [] array = new int [10]; // Создает новый массив, в котором будет 10 элементов

FillArray(array);
array[4] = 4; //Написано специально, чтобы принудительно добавить повторяющиеся значения в массив, при работе удалить из кода 
array[6] = 4; 
PrintArray(array);
Console.WriteLine(); //Делается пустая строка, чтобы отделить результат от выведенного массива

int pos = IndexOf(array, 4); //Указывается значение, которое необходимо найти в массиве, в итоге выведет [индекс] найденного значения
Console.WriteLine(pos);