static void Menu()
{
    Console.WriteLine("Selecione uma opcao:\n1 - Criar novo arquivo\n2 - Editar arquivo existente\n0 - Sair");

    short option = short.Parse(Console.ReadLine());

    switch (option)
    {
        case 0: System.Environment.Exit(0); break;
        case 1: OpenFile(); break;
        case 2: EditFile(); break;
    }
}

static void OpenFile()
{

}

static void EditFile()
{

}

Menu();


