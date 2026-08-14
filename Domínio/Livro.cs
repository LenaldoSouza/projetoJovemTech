namespace Biblioteca.Domínio;

public class Livro(string titulo, string autor, DateTime dataLancamento) : ItemAcervo(titulo, autor, dataLancamento)
{
    public override int PrazoDevolucao => 14;
    public override decimal MultaDiaAtrasado => 1m;
}