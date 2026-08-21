namespace Biblioteca.Domínio;

public class RegistroCliente
{
    public string Nome { get; set; } = string.Empty;
    public DateOnly DataNascimento { get; set; }
    public int LimiteEmprestimo { get; set; }
    private static int _proximoId = 1;
    public int Id { get; }

    public RegistroCliente(string nome, DateOnly dataNascimento)
    {
        Nome = nome;
        DataNascimento = dataNascimento;
        Id = _proximoId++;
    }

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