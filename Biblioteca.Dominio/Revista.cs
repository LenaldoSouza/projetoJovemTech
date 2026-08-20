namespace Biblioteca.Domínio;

public class Revista(string titulo, string autor, DateTime dataLancamento) : ItemAcervo(titulo, autor, dataLancamento)
{
    public override int PrazoDevolucao => 7;
    public override decimal MultaDiaAtrasado => 2m;
}