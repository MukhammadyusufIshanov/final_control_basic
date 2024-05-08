Console.Write("input number of items: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] orig= new string[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"input item {i+1}: ");
    orig[i]=Console.ReadLine()!;
}

string[] MakeNew(string[] s)
{
    string[] s2= new string[s.Length];
    int j=0;
    for (int i = 0; i < s.Length; i++)
    {
        string str=s[i];
        if (str.Length<=3)
        {
            s2[j]=s[i];
            j+=1;
        }
    }
    string[] s3=new string[j];
    for (int i = 0; i < j; i++)
    {
        s3[i]=s2[i];
    }
    return s3;
}

void PrintMas(string[] col)
{
    foreach (var item in col)
    {
        Console.Write($"{item} ");
    }
}
Console.WriteLine("");
Console.WriteLine("from this:");
PrintMas(orig);
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("we get this:");
PrintMas(MakeNew(orig));
