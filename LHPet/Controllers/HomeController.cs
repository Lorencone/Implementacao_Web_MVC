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
        //Instanciando objetos da classe Cliente
        Cliente cliente1 = new Cliente(01, "João Silva", "123.456.789-00", "joao.silva@gmail.com", "Rex");
        Cliente cliente2 = new Cliente(02, "Maria Oliveira", "987.654.321-00", "maria.oliveira@gmail.com", "Luna");
        Cliente cliente3 = new Cliente(03, "Carlos Souza", "456.789.123-00", "carlos.souza@gmail.com", "Max");
        Cliente cliente4 = new Cliente(04, "Ana Pereira", "789.123.456-00", "ana.pereira@gmail.com", "Bella");
        Cliente cliente5 = new Cliente(05, "Pedro Santos", "321.654.987-00", "pedro.santos@gmail.com", "Charlie");

        // Lista de clientes
        List<Cliente> listaClientes = new List<Cliente> { cliente1, cliente2, cliente3, cliente4, cliente5 };
        
        //Exibindo a lista de clientes viewbag
        ViewBag.ListaClientes = listaClientes;

        //Instanciando objetos da classe Fornecedor

        Fornecedor fornecedor1 = new Fornecedor(01, "PetShop Vida Animal", "14.182.102/0001-80", "petshopanimal@vida.com", "Rações e Acessórios");
        Fornecedor fornecedor2 = new Fornecedor(02, "Mundo Pet", "22.345.678/0001-90", "mundopet@petmundo.com", "Brinquedos e Higiene");
        Fornecedor fornecedor3 = new Fornecedor(03, "Amigo Fiel", "33.456.789/0001-10", "amigofiel@fielamigo.com", "Alimentos Naturais");
        Fornecedor fornecedor4 = new Fornecedor(04, "Casa do Bicho", "44.567.890/0001-20", "casadobicho@bichodacasa.com", "Medicamentos e Suplementos");
        Fornecedor fornecedor5 = new Fornecedor(05, "Pet Center", "55.678.901/0001-30", "petcenter@centerpet.com", "Acessórios e Rações Especiais");
        
        // Lista de fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor> { fornecedor1, fornecedor2, fornecedor3, fornecedor4, fornecedor5 };

        //Exibindo a lista de fornecedores na viewbag
        ViewBag.ListaFornecedores = listaFornecedores;

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
