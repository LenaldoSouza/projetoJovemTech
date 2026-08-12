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
    public string? Titulo { get; set; } = string.Empty;
    public string? Autor { get; set; } = string.Empty;
    public bool Disponibilidade { get; set; } = true;
    public abstract int PrazoDevolucao { get; set; }
    public abstract decimal MultaDiaAtrasado { get; set; }

    public decimal CalcularMulta(int diasAtrasados)
    {
        return diasAtrasados >= 0 ? diasAtrasados * MultaDiaAtrasado : diasAtrasados = 0;
    }
}
