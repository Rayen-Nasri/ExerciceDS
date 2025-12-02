namespace Rayen_Nasri

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] T = [];
            int i = 0;
            Random random = new Random();
            while (i <= 50)
            {
                // remplir le tableau de manier aliatoire
                int n = random.Next(0, 10);
                if (n == -1)
                {
                    break;
                }
                T[i] = n;
                i++;
            }
            Console.WriteLine("Un entier ");
            int val = int.Parse(Console.ReadLine());

            Doublon(T, val, i);
            DeuxiemPlusPetit(T, i);


            Console.WriteLine("Un entier pour chercher ");
            int x = int.Parse(Console.ReadLine());

            RechercheSeq(T, i , x);
            Afficher(T , i);
            
            


        static bool Doublon(int[] T, int val, int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (T[i] == val)
                {
                    count++;
                }
            }
            return count > 1;
        }
        }

        static int DeuxiemPlusPetit(int[] T, int n)
        {
            int premierPetitentier = T[0];
            int deuxiemPlusPetit = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                if (premierPetitentier > T[i])
                {
                    premierPetitentier = T[i];
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (deuxiemPlusPetit > T[i] && deuxiemPlusPetit != premierPetitentier && T[i] != premierPetitentier)
                {
                    deuxiemPlusPetit = T[i];
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


