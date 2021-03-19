using MVC_Console.Models;
using MVC_Console.View;

namespace MVC_Console.Controllers
{
    public class ClienteController
    {
        Cliente cliente = new Cliente();
        ClienteView clienteView = new ClienteView();

        public void ListarCliente()
        {
            clienteView.ListarCliente(cliente.LerCliente());
        }

        public void CadastrarClientes()
        {
            cliente.InserirClientes(clienteView.CadastrarCliente());
        }
    }
}