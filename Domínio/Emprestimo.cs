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

    public void ChecarIdade(DateOnly dataNascimento, FaixaEtaria faixaEtaria)
    {
        int idadeAtual = 0;
        if (faixaEtaria == FaixaEtaria.Livre)
        {
            
        }
        else
        {
            DateTime dataAtual = DateTime.Now;
            idadeAtual = dataAtual.Year - dataNascimento.Year;
        }

        if (idadeAtual < FaixaEtaria.)
        {
            Console.WriteLine("Você não pode obter esse item, idade abaixo da permitida."); 
        }
        else
        {
            Console.WriteLine("Não");
        }
    }
}