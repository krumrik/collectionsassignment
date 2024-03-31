using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Queue<T> Collection:");
        Queue<string> gameQueue = new Queue<string>();
        gameQueue.Enqueue("Destiny 2");
        gameQueue.Enqueue("Gran Turismo");
        gameQueue.Enqueue("Pokemon Black");
        gameQueue.Enqueue("Palworld");
        gameQueue.Enqueue("Bloons TD6");
        Console.WriteLine("Queue contains 'Destiny 2': " + gameQueue.Contains("Destiny 2"));
        gameQueue.Dequeue();
        Console.WriteLine("Count: " + gameQueue.Count);
        Console.WriteLine("Games:");
        foreach (var game in gameQueue)
        {
            Console.WriteLine(game);
        }
        Console.WriteLine();

        Console.WriteLine("PriorityQueue<T> Collection:");
        SortedSet<string> priorityQueue = new SortedSet<string>();
        priorityQueue.Add("The Last of Us Part II");
        priorityQueue.Add("God of War");
        priorityQueue.Add("Horizon Zero Dawn");
        priorityQueue.Add("Bloodborne");
        priorityQueue.Add("Dark Souls III");
        while (priorityQueue.Count > 0)
        {
            string highestPriority = priorityQueue.Max;
            Console.WriteLine("Highest Priority Game: " + highestPriority);
            priorityQueue.Remove(highestPriority);
        }
        Console.WriteLine();

        Console.WriteLine("Stack<T> Collection:");
        Stack<string> gameStack = new Stack<string>();
        gameStack.Push("Halo Infinite");
        gameStack.Push("Gears 5");
        gameStack.Push("Call of Duty: Warzone");
        gameStack.Push("Fortnite");
        gameStack.Push("Apex Legends");
        Console.WriteLine("Stack contains 'Fortnite': " + gameStack.Contains("Fortnite"));
        gameStack.Pop();
        Console.WriteLine("Count: " + gameStack.Count);
        Console.WriteLine("Games:");
        foreach (var game in gameStack)
        {
            Console.WriteLine(game);
        }
        Console.WriteLine();

        Console.WriteLine("LinkedList<T> Collection:");
        LinkedList<string> gameList = new LinkedList<string>();
        gameList.AddLast("Minecraft");
        gameList.AddLast("Terraria");
        gameList.AddLast("Stardew Valley");
        gameList.AddLast("Among Us");
        gameList.AddLast("Fall Guys");
        Console.WriteLine("First Game: " + gameList.First.Value);
        Console.WriteLine("Last Game: " + gameList.Last.Value);
        LinkedListNode<string> middleNode = gameList.Find("Stardew Valley");
        gameList.AddBefore(middleNode, "Animal Crossing: New Horizons");
        gameList.RemoveLast();
        Console.WriteLine("Count: " + gameList.Count);
        Console.WriteLine("Games:");
        foreach (var game in gameList)
        {
            Console.WriteLine(game);
        }
        Console.WriteLine();

        Console.WriteLine("Dictionary<TKey, TValue> Collection:");
        Dictionary<int, string> gameDictionary = new Dictionary<int, string>();
        gameDictionary.Add(1, "Overwatch");
        gameDictionary.Add(2, "League of Legends");
        gameDictionary.Add(3, "Counter-Strike: Global Offensive");
        gameDictionary.Add(4, "Rainbow Six Siege");
        gameDictionary.Add(5, "Valorant");
        Console.WriteLine("Keys:");
        foreach (var key in gameDictionary.Keys)
        {
            Console.WriteLine(key);
        }
        Console.WriteLine("Values:");
        foreach (var value in gameDictionary.Values)
        {
            Console.WriteLine(value);
        }
        Console.WriteLine("Key-Value Pairs:");
        foreach (var pair in gameDictionary)
        {
            Console.WriteLine(pair.Key + ": " + pair.Value);
        }
        gameDictionary.Remove(3);
        Console.WriteLine("Count: " + gameDictionary.Count);
        Console.WriteLine();

        Console.WriteLine("SortedList<TKey, TValue> Collection:");
        SortedList<string, string> sortedGameList = new SortedList<string, string>();
        sortedGameList.Add("FPS", "Call of Duty");
        sortedGameList.Add("RPG", "The Elder Scrolls");
        sortedGameList.Add("MMORPG", "World of Warcraft");
        sortedGameList.Add("MOBA", "Dota 2");
        sortedGameList.Add("Battle Royale", "PUBG");
        Console.Write("Enter Genre to Remove: ");
        string genreToRemove = Console.ReadLine();
        if (sortedGameList.ContainsKey(genreToRemove))
        {
            sortedGameList.Remove(genreToRemove);
        }
        else
        {
            Console.WriteLine("Genre does not exist.");
        }
        Console.WriteLine("Games:");
        foreach (var pair in sortedGameList)
        {
            Console.WriteLine(pair.Key + ": " + pair.Value);
        }
        Console.WriteLine();

        Console.WriteLine("HashSet<T> Collection:");
        HashSet<string> gameHashSet1 = new HashSet<string>() { "Super Mario Odyssey", "The Legend of Zelda: Ocarina of Time", "Super Smash Bros. Ultimate", "Animal Crossing: New Horizons", "Mario Kart 8 Deluxe" };
        HashSet<string> gameHashSet2 = new HashSet<string>() { "Super Mario Odyssey", "Minecraft", "Terraria", "Stardew Valley", "Among Us" };
        gameHashSet1.UnionWith(gameHashSet2);
        Console.WriteLine("Combined Games:");
        foreach (var game in gameHashSet1)
        {
            Console.WriteLine(game);
        }
        HashSet<string> gameDuplicates = new HashSet<string>(gameHashSet1);
        gameDuplicates.IntersectWith(gameHashSet2);
        Console.WriteLine("Duplicate Games:");
        foreach (var game in gameDuplicates)
        {
            Console.WriteLine(game);
        }
        Console.WriteLine();

        Console.WriteLine("List<T> Collection:");
        List<string> gameList2 = new List<string>() { "Super Mario Odyssey", "The Legend of Zelda: Ocarina of Time", "Super Smash Bros. Ultimate", "Animal Crossing: New Horizons", "Mario Kart 8 Deluxe" };
        gameList2.AddRange(new string[] { "Minecraft", "Terraria", "Stardew Valley" });
        gameList2.Sort();
        Console.WriteLine("Sorted Games:");
        foreach (var game in gameList2)
        {
            Console.WriteLine(game);
        }
        gameList2.RemoveAt(2);
        gameList2.Reverse();
        Console.WriteLine("Reversed Games:");
        foreach (var game in gameList2)
        {
            Console.WriteLine(game);
        }
    }
}
