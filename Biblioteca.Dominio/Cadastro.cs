using Biblioteca.Domínio;

namespace Biblioteca.Dominio;

public class Cadastro
{
    private readonly List<RegistroCliente> _clientes = [];
    public IReadOnlyList<RegistroCliente> Clientes => _clientes;

    public void Adicionar(RegistroCliente cliente)
    {
        _clientes.Add(cliente);
    }

    public RegistroCliente? BuscarPorId(int id)
    {
        return _clientes.FirstOrDefault(cliente => cliente.Id == id);
    }
}