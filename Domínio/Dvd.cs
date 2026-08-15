namespace Biblioteca.Domínio;

public class Dvd(string titulo, string autor, DateTime dataLancamento) : ItemAcervo(titulo, autor, dataLancamento)
{
    public override int PrazoDevolucao => 3;
    public override decimal MultaDiaAtrasado => 3m;
}
    public enum FaixaEtaria {Livre, Dez, Doze, Quatorze, Dezesseis, Dezoito}