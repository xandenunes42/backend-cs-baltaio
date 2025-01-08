using System.Security.Principal;

namespace MenuScreen;

public static class Menu
{
    public static void Show()
    {
        DrawScreen();
        MenuInside();
    }

    public static void DrawScreen()
    {
        DrawLines();
        DrawCollumns();
        DrawLines();
    }

    static void DrawLines()
    {
        Console.Write("\n");
        Console.Write("+");

        for(int i = 0; i <= 30; i++)
        {
            Console.Write("-");
        }

        Console.Write("+");
    }

    static void DrawCollumns()
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

    static void MenuInside()
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
        short op = short.Parse(Console.ReadLine());
    }
}