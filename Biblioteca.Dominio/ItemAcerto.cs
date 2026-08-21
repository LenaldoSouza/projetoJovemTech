namespace Biblioteca.Domínio;

public abstract class ItemAcervo
{
    private static int _proximoId = 1;
    public int Id { get; }
    public ItemAcervo(string titulo, string autor, DateTime dataLancamento)
    {
        if (string.IsNullOrWhiteSpace(titulo)) throw new ExcecaoDominio("O título é obrigatório.");
        Titulo = titulo;
        Autor = autor;
        DataLancamento = dataLancamento;

        Id = _proximoId++;
    }
    public string? Titulo { get; private set; } = string.Empty;
    public string? Autor { get; private set; } = string.Empty;
    public DateTime? DataLancamento { get; private set; }
    public bool Disponibilidade { get; private set; } = true;
    public abstract int PrazoDevolucao { get; }
    public abstract decimal MultaDiaAtrasado { get; }

    public decimal CalcularMulta(int diasAtrasados)
    {

        return diasAtrasados >= 0 ? diasAtrasados * MultaDiaAtrasado : diasAtrasados = 0;
    }

    public void MarcarComoDevolvido()
    {
        if (Disponibilidade)
        {
            throw new ExcecaoDominio("Não está emprestado");
        }
        Disponibilidade = true;
    }
    public void MarcarComoEmprestado()
    {

        if (!Disponibilidade)
        {
            throw new ExcecaoDominio("Não está emprestado");
        }
        Disponibilidade = false;
    }
}
