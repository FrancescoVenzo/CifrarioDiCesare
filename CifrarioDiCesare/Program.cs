string inp;
int chiave;
char funzione;
string ou = "";
while (true)
{
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
            CifraCesare(inp, chiave);
            break;
        case 'd':
            DecifraCesare(inp, chiave);
            break;
    }
    break;
}










string CifraCesare(string s, int c)
{


    return;
}

string DecifraCesare(string s, int c)
{


    return;
}