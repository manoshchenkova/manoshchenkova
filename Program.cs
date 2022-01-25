//  Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше или равна 3. 

string[] myArray = new string {"monkey", "bug", "bee", "lion", "cat", "dog", "111", "!2&*^"};

string PickItemsFromArray = string [ExternalArray]
{
    string[] ArrayResult = new string[ExternalArray.GetLength];
        for (new int i = 0; i < ExternalArray.GetLength; i++)
            {
                if (ExternalArray[i].Length < 3)
                    ArrayResult[i] = ExternalArray[i];
                else
                    Array.Resize(ref ArrayResult, ArrayResult.Length - 1);
            Console.Write($"{ArrayResult(i)} + " " ");
            }
}

PickItemsFromArray