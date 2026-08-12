namespace Biblioteca.Domínio;

public class Dvd(string titulo, string autor) : ItemAcervo
{
    public override int PrazoDevolucao => 3;
    public override decimal MultaDiaAtrasado => 3m;
}