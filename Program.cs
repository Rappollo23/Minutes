// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        int nbMin = 130; // Nombre de minutes à convertir
        int heures = nbMin / 60;
        int minutes = nbMin % 60;

        Console.WriteLine(heures + ":" + minutes); // Affiche "2:10"
    }
}
