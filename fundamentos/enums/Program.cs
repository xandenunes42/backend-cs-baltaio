
var pessoa1 = new Pessoa("Alexandre", EEstadoCivil.Solteiro);

Console.WriteLine($"{pessoa1.Nome} - {pessoa1.EstadoCivil}.");

//Anatomia
enum EEstadoCivil
{   
    Solteiro = 1,
    Casado = 2,
    Divorciado = 3
}

struct Pessoa
{
    public Pessoa(string nome, EEstadoCivil eEstadoCivil)
    {
        Nome = nome;
        EstadoCivil = eEstadoCivil;
    }

    public string Nome;
    public EEstadoCivil EstadoCivil;

}