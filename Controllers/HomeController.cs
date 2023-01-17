using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        // Instâncias de clientes
        Cliente cliente1 = new Cliente(1,"Martin Garrix jr.", "111.222.333-44", "martin@email.com","Toby");
        Cliente cliente2 = new Cliente(2,"Wandinha paulina", "222.222.222-22", "wandinha@email.com","Mel");
        Cliente cliente3 = new Cliente(3,"Carla montenegro", "333.333.333-33", "carla@email.com","Toy");
        Cliente cliente4 = new Cliente(4,"Jonatan Pascalino", "444.444.444-44", "jontan@email.com","Snowbell");
        Cliente cliente5 = new Cliente(5,"Maria arqumiendez", "555.555.555-55", "maria@email.com","Bobo");
        Cliente cliente6 = new Cliente(6,"Rafael Bonifacio", "666.666.666-66", "rafael@email.com","Princesa");

        // Lista de Clientes
        List<Cliente> listaClientes = new List<Cliente>();

        // Adicionando Clientes na lista
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);
        listaClientes.Add(cliente6);

        ViewBag.listaClientes = listaClientes;

        // Instâncias de Fornecedores
        Fornecedor fornecedor1 = new Fornecedor(1,"Pet Mania", "111.222.333/1111-11", "petmania@email.com");
        Fornecedor fornecedor2 = new Fornecedor(2,"Pet Feliz", "222.222.222/2222-22", "petfeliz@email.com");
        Fornecedor fornecedor3 = new Fornecedor(3,"Clinica selvagem", "333.333.333/3333-33", "clinicaselvagem@email.com");
        Fornecedor fornecedor4 = new Fornecedor(4,"Pet e Tutor", "444.444.444/4444-44", "petetutor@email.com");
        Fornecedor fornecedor5 = new Fornecedor(5,"Paraiso dos Animais", "555.555.555/5555-55", "paraisodosanimais@email.com");
        Fornecedor fornecedor6 = new Fornecedor(6,"Lar dos Pets", "666.666.666/6666-66", "lardospets@email.com");

        // Lista de Fornecedores 
        List<Fornecedor> ListaFornecedores = new List<Fornecedor>();

        // Adicionando Fornrcedores na lista
        ListaFornecedores.Add(fornecedor1);
        ListaFornecedores.Add(fornecedor2);
        ListaFornecedores.Add(fornecedor3);
        ListaFornecedores.Add(fornecedor4);
        ListaFornecedores.Add(fornecedor5);
        ListaFornecedores.Add(fornecedor6);

        ViewBag.ListaFornecedores = ListaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
