using System.Text;
using MenuScreen;

namespace EditorHtml;

public static class Editor
{
    public static void Show()
    {
        Console.Clear();
        Console.WriteLine("MODO EDITOR");

        Start();
    }

    public static void Start()
    {
        var file = new StringBuilder();

        do
        {
            file.Append(Console.ReadLine());
            file.Append(Environment.NewLine);

        } while (Console.ReadKey().Key != ConsoleKey.Escape);

        Console.WriteLine("Desaja salvar o arquivo ?");

        var op = Console.ReadLine().ToUpper();

        
        if(op.StartsWith("S"))
        {
            Console.WriteLine("Informe o caminho: ");

            var path = Console.ReadLine();
        }
        else if(op.StartsWith("N"))
        {
            Console.WriteLine("Arquivo nao sera salvo!");
        }

        Menu.Show();

    }
}