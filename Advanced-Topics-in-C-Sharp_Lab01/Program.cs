

using System.Text;

//concatenate
void Concatenate(string wordArg, int numArg)
{
    Console.WriteLine(new StringBuilder(wordArg.Length * numArg)
        .Insert(0, wordArg, numArg).ToString());
}

Concatenate("abcd", 3);


//remove
void RemoveString(string wordArg, int numArg)
{
    Console.WriteLine(wordArg.Remove(wordArg.Length - numArg, numArg));
}

RemoveString("abcdefg", 2);

delegate void DelegateFunction(string wordArg, int numArg);
