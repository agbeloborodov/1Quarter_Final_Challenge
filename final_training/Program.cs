/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа.
   Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма.
   При решении обойтись исключительно массивами. */

internal class Program
{
    private static void Main(string[] args)
    {
        string[] arrayDefine = new string[]                                             //Формирование массива
        {
            "hello", "2", "-1", "world", ":-)", "Moskow", "Denmark", "Kazan", "124", "1567", "other symbol", "WTF", "21", "11"
        };
        void OutputArrayToConsole(string[] array)                                       //Вывод сформированого массива в консоль
        {
            for (int i = 0; i < array.GetLength(0); i++) Console.Write("'" + array[i] + "'" + ", ");
            Console.WriteLine();
        }
        int count=0;
        Console.WriteLine("Задан массив строк:");
        OutputArrayToConsole(arrayDefine);
        Console.WriteLine("Теперь среди них отыщем те строки, содержащие меньше 4-х символов. Результат таков:");
        for (int i = 0; i < arrayDefine.Length; i++)
        {
            if (arrayDefine[i].Length < 4) count++;
        }
        string [] newArray = new string [count];
        count = 0;
        for (int i = 0; i < arrayDefine.Length; i++)
        {
           if (arrayDefine[i].Length < 4)
           {
            newArray[count] = arrayDefine[i] ;
            count++;
           }
        }
    OutputArrayToConsole(newArray);
    }
}