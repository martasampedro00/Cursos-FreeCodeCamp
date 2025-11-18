string pangram = "The quick brown fox jumps over the lazy dog";

string[] palabras = pangram.Split(" ");
string[] palabrasReves = new string[palabras.Length];
int size = palabras.Length-1;
for(int i=size; i>=0; i--)
{
    char[] palabraSeparada= palabras[i].ToCharArray();
    Array.Reverse(palabraSeparada);
    string palabraR = new string(palabraSeparada);
    palabrasReves[i] = palabraR;
}

string result = String.Join(" ", palabrasReves);

Console.WriteLine(result);