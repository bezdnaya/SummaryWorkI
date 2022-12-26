// Cоздать новый массив, который состоит из эдементов меншье или равно 3 символов из имеющегося массива.

void FillArray (string[] collection)
{
    string[] Baza = new string [] {"a", "b", "c", "d", "e", "f", "g", "h", "q", "w", "r", "t", "y", "u", "i", "o", "p", "s", "j", "k", "l", "z", "x", "v", "n", "m"};
    for (int i = 0; i < collection.Length; i++)
    {
        int elementLength = new Random().Next(1, 10);
        string element = string.Empty;
        for (int j = 0; j < elementLength; j++)
        {
            element += Baza[new Random().Next(0, Baza.Length)];
        }
        collection [i] = element;

    }
}
void PrintArray (string [] coll)
{
    Console.WriteLine(string.Join(", ", coll));
}
string [] StartArray = new string [new Random().Next(1, 11)];
FillArray(StartArray);
Console.WriteLine ("Исходный массив:");
PrintArray(StartArray);
int len = 0;
string [] ResArray = new string [len];
for (int i = 0; i < StartArray.Length; i++)
{
    if (StartArray[i].Length < 4)
    {
        Array.Resize(ref ResArray, len + 1);
        ResArray[len] = StartArray [i];
        len ++;
    }
}
Console.WriteLine ();
Console.WriteLine ("Массив с элементами до 4 символов:");
PrintArray(ResArray);



