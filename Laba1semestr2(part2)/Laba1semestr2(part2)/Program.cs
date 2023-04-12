using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;



try
{
    Console.Write("Введiть число для ключа: ");
    int n = Convert.ToInt32(Console.ReadLine());

    var fruits = new Dictionary<int, string>()
    {
        [4] = "orange",
        [6] = "pineapple",
        [7] = "pear",
        [5] = "carrot",
        [9] = "plum",
        [18] = "apple"
    };

    Console.WriteLine("Словник до фiльтрацiї:");

    foreach (var fruit in fruits)
    {
        Console.WriteLine($"ключ: {fruit.Key}  фрукт: {fruit.Value}");
    }

    Console.WriteLine("Словник пiсля фiльтрацiї:");

    var newfruits = new Dictionary<int, string>();
    foreach (var pair in fruits)
    {
        if (pair.Key >= n)
        {
            newfruits.Add(pair.Key, pair.Value);
        }
    }
    if (newfruits.Count > 0)
    {
        foreach (var pair in newfruits)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
        var path = @"D:\Arsen\Studying KPI\visual projects\Laba1semestr2(part2)\meow.json";
        string json = JsonConvert.SerializeObject(newfruits);
        File.WriteAllText(path,json);
    }
    else
    {
        Console.WriteLine("усi ключи меншi за введене значення");
    }
}
catch (FormatException)
{
    Console.WriteLine("Невiрний формат");
}
