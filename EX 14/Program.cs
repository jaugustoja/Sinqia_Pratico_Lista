using EX_14.Models;

Album album1 = new Album(10);

album1.ColarFigurinhas(5);
album1.ColarFigurinhas(3);
album1.ColarFigurinhas(7);

foreach(int figuras in album1.ArrayFigurinhasColadas)
{
    if (figuras != 0)
    {
        Console.WriteLine(figuras);
    }
}

