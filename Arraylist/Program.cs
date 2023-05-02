using System;
using System.Collections;

namespace Corso
{
    class Program
    {
        static void Main(string[] args)
        {
            //ARRAY LIST non hanno numero finito di valori e valori diversi tra loro
            ArrayList prova = new ArrayList();
            prova.Add(2);
            prova.Add("ciao");
            ArrayList prova2 = new ArrayList()
            {
                3,"prova",true,4,null
            };
            Console.WriteLine(prova2[2]);

            //AGGIUNGERE
            int[] array_interi = { 1, 2, 3,};
            prova.Add(2);
            prova.AddRange(array_interi);
            //AGGIUNGERE IN POSIZIONE SPECIFICA
            prova.Insert(0, "ciao"); //alla posizione 0 aggiunge ciao

            //MODIFICARE
            prova[0] = "buonasera";

            //ELIMINARE
            prova.Remove(3); //rimuove il 3 dall'arraylist
            prova.RemoveAt(0); //rimuovere alla posizione
            prova.RemoveRange(0, 2); //dalla posizione 0 ne elimino 2

            //CONTAINS
            Console.WriteLine(prova.Contains(3)); //continene 3? vero o falso

            //ITERAZIONE
            foreach(var prova_singola in prova)
            {
                Console.WriteLine(prova_singola);
            }
            for (int i = 0; i < prova.Count; i++)
            {
                Console.WriteLine(prova[i]);
            }
        }
    }
}
