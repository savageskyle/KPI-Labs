using System;
using System.Collections;

class Laba1_semestr2
{
    public static void Main(string[] args)
    {
        /*Console.Write("Введiть кiлькiсть людей: ");
        int n = Convert.ToInt32(Console.ReadLine());
        ArrayList list = new ArrayList();

        // Заповнюємо список людьми
        for (int i = 1; i <= n; i++)
        {
            list.Add(i);
        }

        int currentIndex = 0;

        while (list.Count > 1)
        {
            // Видаляємо кожну другу людину
            currentIndex = (currentIndex + 1) % list.Count;
            list.RemoveAt(currentIndex);

            // Якщо це була остання людина, завершуємо цикл
            if (currentIndex == list.Count)
            {
                currentIndex = 0;
            }
        }

        Console.WriteLine("Остання людина, що залишилась: " + list[0]);*/

        Console.Write("Введiть кiлькiсть людей: ");
        int n = Convert.ToInt32(Console.ReadLine());
        LinkedList<int> list = new LinkedList<int>();

        // Заповнюємо список людьми
        for (int i = 1; i <= n; i++)
        {
            list.AddLast(i);
        }

        LinkedListNode<int> currentNode = list.First;

        while (list.Count > 1)
        {
            // Видаляємо кожну другу людину
            LinkedListNode<int> nextNode = currentNode.Next ?? list.First;
            list.Remove(nextNode);

            // Перехід до наступної людини
            currentNode = currentNode.Next ?? list.First;
        }

        Console.WriteLine("Остання людина, що залишилась: " + list.First.Value);
    }
}