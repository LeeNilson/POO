public class Pessoa
{
    private string Nome { get;set; }

    private string Endereco {get;set;}
    public void Pessoa(string nome, string endereco)
    {
        Nome = nome;
        Endereco = endereco;
    }

    public virtual void ExibirDados(){
        Console.WriteLine($"Nome:{Nome}");
        Console.WriteLine($"Endereco:{Endereco}");
        Console.WriteLine($"{Nome} {Endereco}");

    }
}