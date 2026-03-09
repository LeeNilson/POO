public class PessoaFisica: Pessoa
{
    string cpf { get;set;}

    public PessoaFisica(string nome, string endereco):base (nome;endereco)
    {
        CPF = cpf;
    }
    
    public override void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine($" CPF:{CPF}");
    }
}