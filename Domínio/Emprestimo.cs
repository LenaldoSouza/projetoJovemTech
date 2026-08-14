namespace Biblioteca.Domínio;

public class Emprestimo
{
    public ItemAcervo Item { get; private set; }

    public DateTime DataEmprestimo { get; private set; } = DateTime.Now;
    
    public DateTime PrazoLimite {get;}

    public Emprestimo(ItemAcervo item)
    {
        item.MarcarComoEmprestado();
        Item = item;
        PrazoLimite = DataEmprestimo.AddDays(item.PrazoDevolucao);
    }

    public decimal MultaAtual => Item.CalcularMulta(QtdDiasAtrasados);

    public int QtdDiasAtrasados
    {
        get
        {
            TimeSpan diasAtrasado = DataEmprestimo - PrazoLimite;
            return diasAtrasado.Days;
        }
    }

    public void RegistrarDevolucao()
    {
        Item.MarcarComoDevolvido();
    }
}