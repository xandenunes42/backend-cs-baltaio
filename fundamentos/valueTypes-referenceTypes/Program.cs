//Value Types

int x = 1;
int y = 2;

y = x; // y recebe uma cópia de x

Console.WriteLine(x); // 1
Console.WriteLine(y); // 1 - cópia de x 

x = 10;

Console.WriteLine(x); // 10
Console.WriteLine(y); // somente x eh alterado

//Reference Types 

var array = new string[2];
array[0] = "Item 1";

Console.WriteLine(array[0]);

var refArray = array; // Não cria uma cópia

Console.WriteLine(refArray[0]);

refArray[0] = "Item Alterado";

Console.WriteLine(array[0]); // Valor alterado, pois a referencia aponta pro mesmo lugar
