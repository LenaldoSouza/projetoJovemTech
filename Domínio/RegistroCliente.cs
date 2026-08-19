namespace Biblioteca.Domínio;

public class RegistroCliente
{
    public string Nome { get; set; } = string.Empty;
    public DateOnly DataNascimento { get; set; }
    public int LimiteEmprestimo { get; set; }

    public bool PodeSerEmprestado()
    {
        if (LimiteEmprestimo >= 3)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}