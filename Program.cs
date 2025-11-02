using System;

class Bouquet
{
    public string Flowers;
    public Bouquet Clone() => (Bouquet)this.MemberwiseClone();
}

class Program
{
    static void Main()
    {
        var original = new Bouquet { Flowers = "Троянди " };
        var copy = original.Clone();

        copy.Flowers = "Тюльпани ";

        Console.WriteLine("Оригінал: " + original.Flowers);
        Console.WriteLine("Копія: " + copy.Flowers);
    }
}





