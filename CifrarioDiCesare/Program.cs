string inp;
int chiave;
char funzione;
string ou = "";
while (true)
{
    Console.WriteLine("Premi a per fermarti");
    if (Console.ReadLine() == "a")
        break;
    Console.WriteLine("Inserisci il testo: ");
    inp = Console.ReadLine();

    Console.WriteLine("Inserisci la chiave di spostamento: ");
    if (!(int.TryParse(Console.ReadLine(), out chiave)))
    {
        Console.WriteLine("Chiave non valida");
    }

    Console.WriteLine("Vuoi cifrare o decifrare? c/d:");
    funzione = Console.ReadKey().KeyChar;
    switch (funzione)
    {
        case 'c':
            ou = CifraCesare(inp, chiave);
            break;
        case 'd':
            ou = DecifraCesare(inp, chiave);
            break;
    }
    Console.Write("\n");
    Console.WriteLine(ou);
}



string CifraCesare(string s, int c)
{
    string risultato = "";
    s = s.ToLower();

    foreach (char ch in s)
    {
        if (ch + c < 123)
            risultato += (char)(ch + c);
        else
            risultato += (char)(97 + (ch + c - 122));
    }

    return risultato;
}

string DecifraCesare(string s, int c)
{
    string risultato = "";
    s = s.ToLower();

    foreach (char ch in s)
    {
        if (ch - c > 96)
            risultato += (char)(ch - c);
        else
            risultato += (char)(122 - (ch - c + 97));
    }

    return risultato;
}