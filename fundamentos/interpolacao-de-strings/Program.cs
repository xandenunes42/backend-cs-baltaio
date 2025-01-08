var price = 10.2;
var text = "O preco do produto eh: " + price;
//price do tipo double eh convertido automatiamente em string com sinal de +

var price2 = 9;
var text2 = string.Format("O preco do produto eh {0}.", price2);
//utilizando string.Format


var price3 = 10;
var text3 = $"O preco do produto eh R${price3} reais";
//utilizando o $ (Meu metodo preferido)


Console.WriteLine(text3);
