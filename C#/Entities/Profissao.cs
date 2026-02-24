namespace helloMundo.Entities;

public class Profissao
{
    public string Titulo { get; set; } = "";
    public double Salario { get; set; }

    public Profissao(string titulo, double salario)
    {
        Titulo = titulo;
        Salario = salario;
    }
}