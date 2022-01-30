//Написать программу, которая из имеющегося массива строк формирует массив 

string[] array = { "кря", "привет", "123", ":-)" };
string[] newarray = new string[0];
for (int i = 0; i < array.Length; i++)
{
    int j = 0;
    if (array[i].Length < 4)
    { 
        Array.Resize(ref newarray, j + 1);
        newarray[j] = array[i];
        Console.Write($"{newarray[j]}; ");
    }
} 