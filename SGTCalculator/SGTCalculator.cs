using SGTCalculator;

int[] arrayToSort = { 103, 100, 5, 36, 695, 45, 3, 2, 7 };

for (int amountOfTimeLooped = 0; amountOfTimeLooped < arrayToSort.Length - 1; amountOfTimeLooped++)
{
    for (int pos = 0; pos < arrayToSort.Length -1; pos++)
    {
        if (arrayToSort[pos] > arrayToSort[pos + 1]) //arrayToSort[0] > arrayToSort[1] // 103 > 100
        {
            var temp = arrayToSort[pos + 1]; // arrayToSort[1] 100
            arrayToSort[pos + 1] = arrayToSort[pos]; // arrayToSort[1] = 103
            arrayToSort[pos] = temp; // 100
        }
    }
}

foreach (var item in arrayToSort)
{
    Console.Write($"{item} ");
}

List<int> listToSort = new List<int> { 103, 100, 5, 36, 695, 45, 3, 2, 7 }; 
listToSort.Sort();


foreach (var item in listToSort)
{
    Console.Write($"{item} ");
}


// Queue - FIFO - first in first out  // 2 methods, Enqueue and Dequeue


Queue<int> queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);

var maxQueueCount = queue.Count;
for (int i =0; i < maxQueueCount; i++)
{
    Console.Write($"{queue.Dequeue()} ");
}
Console.WriteLine();

Stack<int> stack = new Stack<int>();

// Stack - LIFO - Last in first out //Push(Puts data in) Pop(Gets data out)

stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(5);
var maxStackCount = stack.Count;

for (int j = 0; j < maxStackCount; j++)
{
    Console.Write($"{stack.Pop()} ");
}


Dictionary<string, string> dictionary = new Dictionary<string, string>();
dictionary.Add("a", "Alphabet");
dictionary.Add("b", "Beta");

Console.WriteLine(dictionary["a"]);

Dictionary<int, string> intKeyDicitonary = new Dictionary<int, string>();

intKeyDicitonary.Add(0, "Valera");
intKeyDicitonary.Add(1, "Boro");

Console.WriteLine($"{intKeyDicitonary[0]}");
