namespace Biblioteca.Domínio;

public class Emprestimo
{
    public ItemAcervo Item { get; private set; }

    public DateTime DataEmprestimo { get; private set; } = DateTime.Now;

    public DateTime PrazoLimite { get; }

    public int QuantidadeItens {get;set;}

    public Emprestimo(ItemAcervo item, RegistroCliente nome)
    {
        item.MarcarComoEmprestado();
        Item = item;
        PrazoLimite = DataEmprestimo.AddDays(item.PrazoDevolucao);
        RegistroCliente.LimiteEmprestimo++;
    }

    public decimal MultaAtual => Item.CalcularMulta(QtdDiasAtrasados);
    public int QtdDiasAtrasados
    {
        
        get
        {
            TimeSpan diasAtrasado = DateTime.Now - PrazoLimite;
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
            Console.WriteLine("Item liberado para todas as idades.");
        }
        else
        {
            int faixaEtariaInNum = faixaEtaria switch
            {
                FaixaEtaria.Dez => 10,
                FaixaEtaria.Doze => 12,
                FaixaEtaria.Quatorze => 14,
                FaixaEtaria.Dezesseis => 16,
                FaixaEtaria.Dezoito => 18,
                _ => 0
            };
            DateOnly hoje = DateOnly.FromDateTime(DateTime.Now);
            idadeAtual = hoje.Year - dataNascimento.Year;
            if (hoje < dataNascimento.AddYears(idadeAtual))
            {
                idadeAtual--;
            }
            if (idadeAtual < faixaEtariaInNum)
            {
                Console.WriteLine("Você não pode obter esse item, idade abaixo da permitida.");
            }
            else
            {
                Console.WriteLine("Item liberado para o cliente.");
            }
        }
    }
}