using System.Security.Principal;
using EditorHtml;

namespace MenuScreen;

public static class Menu
{
    public static void Show()
    {
        DrawScreen();
        MenuInside();

        short op = short.Parse(Console.ReadLine());

        HandleMenuOption(op);
    }

    public static void DrawScreen()
    {
        DrawLines();
        DrawCollumns();
        DrawLines();
    }

    public static void DrawLines()
    {
        Console.Write("\n");
        Console.Write("+");

        for(int i = 0; i <= 30; i++)
        {
            Console.Write("-");
        }

        Console.Write("+");
    }

    public static void DrawCollumns()
    {
        for(int i = 0; i <= 10; i++)
        {
            Console.Write("\n");
            Console.Write("|");

            for(int j = 0; j <= 30; j++)
            {
                Console.Write(" ");
            }
            
            Console.Write("|");
        }
    }

    public static void MenuInside()
    {
        Console.SetCursorPosition(2, 1);
        Console.Write("HTML EDITOR");
        Console.SetCursorPosition(2, 3);
        Console.Write("SELECIONE UMA OPCAO: ");
        Console.SetCursorPosition(2, 5);
        Console.Write("1 - NOVO ARQUIVO");
        Console.SetCursorPosition(2, 7);
        Console.Write("2 - ABRIR");
        Console.SetCursorPosition(2, 9);
        Console.Write("0 - SAIR");
        
        Console.SetCursorPosition(2, 11);
        Console.Write("OPCAO: ");
    }

    public static void HandleMenuOption(short option)
    {
        switch(option)
        {
            case 1: Editor.Show(); break;
            case 2: Console.WriteLine("Abrir"); break;
            case 0: Environment.Exit(0); break;
        }
    }
}