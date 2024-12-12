﻿
// Criacao da Struct
var product1 = new Product(1, "Mouse", 20.00f);
float priceDolar = product1.PriceInDolar(5.95f);


Console.WriteLine($"Id: {product1.Id}");
Console.WriteLine($"Title: {product1.Title}");
Console.WriteLine($"Price: {product1.Price}");
Console.WriteLine($"Price in dolar: {priceDolar}");


//Anatomia de uma Struct
struct Product
{

    //Construtor -> Método com mesmo nome da estrutura
    public Product(int id, string title, float price)
    {
        Id = id;
        Title = title;
        Price = price;
    }


    //Propriedades
    public int Id;
    public string Title;
    public float Price;


    //Metodos
    public float PriceInDolar(float dolar)
    {
        return dolar * Price;
    }

}
