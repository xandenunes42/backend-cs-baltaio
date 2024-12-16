Console.Clear();

string input = "10s";

char letter = char.Parse(input.Substring(input.Length - 1, 1));
//Captura o ultimo elemento da string

int time = int.Parse(input.Substring(0, input.Length - 1));
//Captura todos elementos da string com excecao do ultimo

Console.Write("Iniciando cronometro");
Thread.Sleep(1000);
Console.Write(".");
Thread.Sleep(1000);
Console.Write(".");
Thread.Sleep(1000);
Console.Write(".");

Console.Clear();

while(time >= 0)
{
    Console.Clear();
    Console.WriteLine(time);
    Thread.Sleep(1000);
    time--;
}

Console.Clear();
Console.WriteLine("Fim do cronometro !!!");

