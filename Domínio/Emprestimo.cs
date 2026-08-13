namespace Biblioteca.Domínio;

public class Emprestimo
{
    public ItemAcervo Item { get; private set; }

    public DateTime DataEmprestimo { get; private set; } = DateTime.Now;
    
    public DateTime PrazoLimite {get;}
}