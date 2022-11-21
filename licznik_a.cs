using System;
using System.IO;

class Licznik_a {
    static void Main() 
    {
        string tekst = File.ReadAllText("plik.txt");
        int litery = 0;
        foreach (char litera in tekst)
        {
            if (litera == 'a')
                litery++;
        }
        Console.WriteLine(litery);

    }
}