using System.Security.Cryptography;
using System.Text.Json;


#region Random.Shared.GetItems example

Console.WriteLine("Random.Shared.GetItems example:");

var names = new string[] { "Bob", "Ana", "Jessica", "Mike", "Rick" };
Console.WriteLine($"Names: {JsonSerializer.Serialize(names)}");

var randomlySelectedNames = Random.Shared.GetItems(names, 2);
Console.WriteLine($"Selected names: {JsonSerializer.Serialize(randomlySelectedNames)}{Environment.NewLine}");

#endregion 


#region Random.Shared.Shuffle example

Console.WriteLine("Random.Shared.Shuffle example:");

var numbers = new int[] { 1, 2, 3, 4, 5, };
Console.WriteLine($"Numbers before shuffling: {JsonSerializer.Serialize(numbers)}");

Random.Shared.Shuffle(numbers);
Console.WriteLine($"Numbers after shuffling: {JsonSerializer.Serialize(numbers)}{Environment.NewLine}");

#endregion 


#region RandomNumberGenerator example

Console.WriteLine("RandomNumberGenerator example:");

var randomString = RandomNumberGenerator.GetString("HelloDotNet8", 10);
Console.WriteLine($"Random number generator: {JsonSerializer.Serialize(randomString)}");

#endregion


#region Old approach examples

Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Old approach examples:");
Console.WriteLine();

var namesOldApproach = new string[] { "Bob", "Ana", "Jessica", "Mike", "Rick" };

var random = new Random();
var randomlySelectedNamesOldApproach = namesOldApproach.OrderBy(_ => random.Next()).Take(2).ToArray();
Console.WriteLine($"Randomly selected names: {JsonSerializer.Serialize(randomlySelectedNamesOldApproach)}");

var randomlySelectedName = namesOldApproach[random.Next(namesOldApproach.Length)];
Console.WriteLine($"Randomly selected name: {JsonSerializer.Serialize(randomlySelectedName)}{Environment.NewLine}");


// Shuffling an array, example 1:
var numbersOldApproach = new int[] { 1, 2, 3, 4, 5, };
Console.WriteLine($"Numbers before shuffling: {JsonSerializer.Serialize(numbersOldApproach)}");

var shuffledArray = numbersOldApproach.OrderBy(_ => random.Next()).ToArray();
Console.WriteLine($"Numbers after shuffling, example 1: {JsonSerializer.Serialize(shuffledArray)}");

// Shuffling an array, example 2:
numbersOldApproach = new int[] { 1, 2, 3, 4, 5, };
Console.WriteLine($"Numbers before shuffling: {JsonSerializer.Serialize(numbersOldApproach)}");

int numbersLength = numbersOldApproach.Length;

// Fisher-Yates shuffle Algorithm:
for (int i = numbersLength - 1; i > 0; i--)
{
    int j = random.Next(i + 1);

    // Swap array[i] and array[j];
    var temp = numbersOldApproach[i];
    numbersOldApproach[i] = numbersOldApproach[j];
    numbersOldApproach[j] = temp;
}

Console.WriteLine($"Numbers after shuffling, example 2: {JsonSerializer.Serialize(numbersOldApproach)}");
Console.WriteLine("-------------------------");

#endregion