using System.Windows.Markup;

namespace Biblioteca.Domínio;

public abstract class ItemAcervo
{
    public ItemAcervo(string titulo, string autor)
    {
        if (string.IsNullOrWhiteSpace(titulo)) throw new ExcecaoDominio("O título é obrigatório.");
        Titulo = titulo;
        Autor = autor;
    }
    public string? Titulo { get; private set; } = string.Empty;
    public string? Autor { get; private set; } = string.Empty;
    public bool Disponibilidade { get; private set; } = true;
    public abstract int PrazoDevolucao { get; }
    public abstract decimal MultaDiaAtrasado { get; }

    public decimal CalcularMulta(int diasAtrasados)
    {
        return diasAtrasados >= 0 ? diasAtrasados * MultaDiaAtrasado : diasAtrasados = 0;
    }
}
