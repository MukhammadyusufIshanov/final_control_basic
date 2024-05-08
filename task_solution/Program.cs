int n=3;
string[] orig= new string[n];
orig[0]="big";
orig[1]="123";
orig[2]="biggie";

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
    return s2;
}

void PrintMas(string[] col)
{
    foreach (var item in col)
    {
        Console.WriteLine(item);
    }
}

 PrintMas(MakeNew(orig));
