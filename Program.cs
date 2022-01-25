//  Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше или равна 3. 

string[] myArray = new string[] {"monkey", "a", "12", "bee", "lion", "cat", "dog", "111", "!2&*^"};

void PrintArray(string[] ExternalArray)
{
    for(int i = 0; i < ExternalArray.Length; i++)
        Console.Write(ExternalArray[i] + " ");
        Console.WriteLine();
}

string[] PickItemsFromArray(string[] ExternalArray)
{
    string[] ArrayResult = new string[ExternalArray.Length];

    int counter = 0;
    for (int i = 0; i < ExternalArray.Length; i++)
    {
        if (ExternalArray[i].Length <= 3) 
        {
            ArrayResult[counter] = ExternalArray[i];
            counter = counter + 1;
        }
    }

    Array.Resize(ref ArrayResult, counter);
    return ArrayResult;
}

Console.WriteLine("Original array: ");
PrintArray(myArray);

string[] ArrayFinal = PickItemsFromArray(myArray);

Console.WriteLine("Array with items with less than 3 symbols is:");
PrintArray(ArrayFinal);
