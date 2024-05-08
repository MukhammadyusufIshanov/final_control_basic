int n=3;
string[] orig= new string[n];
orig[0]="initial";
orig[1]="123";
orig[2]="biggie";

string[] MakeNew(string[] s)
{
    string[] s2= new string[s.Length];
    for (int j = 0; j < s.Length; j++)
    {
    for (int i = 0; i < s.Length; i++)
    {
        string str=s[i];
        if (str.Length<3)
        {
            s2[j]=s[i];
        }
    }
    }
    return s2;
}

void PrintMas(string[] col)
{
    foreach (var item in col)
    {
        Console.Write($"{item} ");
    }
}

PrintMas(MakeNew(orig));