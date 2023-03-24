// Написать программу, которая из имеющегося массива
//строк формирует массив из строк, длина которых меньше 
// либо равна 3 символам7
// первоначальный массив можно ввести с клавиатуры, либо 
// задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами

using System;
using static System.Console;

Clear();


Console.WriteLine("Введите строку для обработки: ");
string originalString = Console.ReadLine();
string[] nums = originalString.Split(' ', 
StringSplitOptions.RemoveEmptyEntries); // Формирование массива строк 
//из введённого предложения. Разделение по пробелу 
Console.WriteLine("Исходный массив: ");
    for (int i = 0; i < nums.Length; i++)
Console.Write(nums[i] + " ");  // Вывод на экран введённой строки 
//в виде массива строк и без разрывов 
Console.WriteLine();
Console.WriteLine("Отсортированный массив: ");
var size = 0;
int mas = 3;
var resultString = new string[nums.Length];  // создаем новый 
//массив, куда будут записываться отсортированные значения

foreach (var value in nums)
{
if (value.Length <= mas)  // сортировка будет происходить по трём 
//символам, включая знаки препинания и спецсимвола, если в параметре 
//split не было указано иное

   {
    resultString[size] = value;
    Console.Write(resultString[size] + ' ');  //вывод нового массива из 
    //строк 3 и менее символов
    size++;
   }
}
