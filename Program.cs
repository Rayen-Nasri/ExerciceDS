using System;
using System.Diagnostics.CodeAnalysis;
namespace Rayen_Nasri

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] T = [];
            int i = 0;
            while (i <= 50)
            {
                Console.WriteLine("Un entier ");
                int n = int.Parse(Console.ReadLine());
                if (n != -1)
                {
                    break;
                }
                T[i] = n;
            }
            Console.WriteLine("Un entier ");
            int val = int.Parse(Console.ReadLine());

            Doublon(T, val, i);
            DeuxiemPlusPetit(T, i);


            Console.WriteLine("Un entier pour chercher ");
            int x = int.Parse(Console.ReadLine());

            RechercheSeq(T, i , x);
            Afficher(T , i);



        }
        static bool Doublon(int[] T, int val, int n)
        {
            int count = 0;
            bool exist = false;
            for (int i = 0; i < n; i++)
            {
                if (T[i] == val)
                {
                    count++;
                }
                return count > 1;
            }
            return exist;
        }

        static int DeuxiemPlusPetit(int[] T, int n)
        {
            int premierPetitentier = T[0];
            int deuxiemPlusPetit = premierPetitentier;
            for ( int i = 0; i < n;i++)
            {
                if (premierPetitentier > T[i + 1])
                {
                    premierPetitentier = T[i + 1];
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (deuxiemPlusPetit > T[i + 1] && deuxiemPlusPetit!= premierPetitentier)
                {
                    deuxiemPlusPetit = T[i + 1];
                }
            }

            return deuxiemPlusPetit;

        }
        static bool RechercheSeq(int[] T, int n, int x)
        {
            bool exist = false;
            for (int i = 0; i < n; i++) {
                if (x == T[i])
                {
                    exist = true;
                    break;
                }
            }
            return exist;
        }
        static void Afficher(int[] T, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(T[i]);
            }
        }

    }
}


