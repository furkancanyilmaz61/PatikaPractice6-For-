using System;

class Program
{
    static void Main()
    {
        // 1. Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırın.
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
        }

        Console.WriteLine(); // Boşluk bırakmak için.

        // 2. 1 ile 20 arasındaki sayıları konsol ekranına yazdırın.
        Console.WriteLine("1 ile 20 arasındaki sayılar:");
        for (int i = 1; i <= 20; i++)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine(); // Yeni satır için.
        Console.WriteLine(); // Boşluk bırakmak için.

        // 3. 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırın.
        Console.WriteLine("1 ile 20 arasındaki çift sayılar:");
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine(); // Yeni satır için.
        Console.WriteLine(); // Boşluk bırakmak için.

        // 4. 50 ile 150 arasındaki sayıların toplamını ekrana yazdırın.
        int total = 0;
        for (int i = 50; i <= 150; i++)
        {
            total += i;
        }
        Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + total);

        Console.WriteLine(); // Boşluk bırakmak için.

        // 5. 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırın.
        int oddTotal = 0, evenTotal = 0;
        for (int i = 1; i <= 120; i++)
        {
            if (i % 2 == 0)
            {
                evenTotal += i;
            }
            else
            {
                oddTotal += i;
            }
        }
        Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı: " + oddTotal);
        Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı: " + evenTotal);
    }
}
