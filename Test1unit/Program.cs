string[] givenArray = new string[] {"heido", "^.^", "Russia", "IT", "Andromeda", "AreYouStillHere"};

int length = 0;
for (int i = 0; i < givenArray.Length; i++)
{
    if (givenArray[i].Length < 4) length++;
}

string[] resArray = new string[length];

void ThreeSymbolsArray(string[] array, string[] arrayres)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            arrayres[count] = array[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"„{array[i]}“ ");
    }
    Console.Write("]");
}

ThreeSymbolsArray(givenArray, resArray);
PrintArray(givenArray);
Console.WriteLine();
PrintArray(resArray);
