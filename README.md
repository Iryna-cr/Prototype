# Prototype

Ідея прототипу: 

створювати нові об’єкти копіюванням існуючих.

Як працює код: 

є один зразок квітки, і при потребі створюємо “клон”.

Навіщо: 

швидше, ніж створювати з нуля, і не потрібно знати деталі конструкції.

## Код
```csharp
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
```
## Результат
![Результат виконання](sc4.png)
