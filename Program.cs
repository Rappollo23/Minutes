// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Demande à l'utilisateur d'entrer un nombre de minutes
        Console.Write("Entrez un nombre de minutes : ");
        int nbMin = int.Parse(Console.ReadLine()); // Récupère l'entrée utilisateur et la convertit en entier

        // Conversion en heures et minutes
        int heures = nbMin / 60;
        int minutes = nbMin % 60;

        // Affichage du résultat
        Console.WriteLine("Résultat : " + heures + ":" + minutes);
    }
}
