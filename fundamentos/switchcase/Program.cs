Random randomKey = new Random();
int key = randomKey.Next(1,7);

switch (key)
{
    case 1: Console.WriteLine($"{key} - Lose!"); break;
    case 2: Console.WriteLine($"{key} - Lose!"); break;
    case 3: Console.WriteLine($"{key} - Lose!"); break;
    case 4: Console.WriteLine($"{key} - Lose!"); break;
    case 5: Console.WriteLine($"{key} - Right"); break;
    case 6: Console.WriteLine($"{key} - Lose"); break;
}

bool? value = null;

switch (value)
{
    case true: Console.WriteLine($"{value}"); break;
    case false: Console.WriteLine($"{value}"); break;
    default: Console.WriteLine("NULL"); break;
}
