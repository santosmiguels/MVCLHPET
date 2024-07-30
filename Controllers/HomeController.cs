using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPET.Models;

namespace LHPET.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1=new Cliente(01, "José1", 123, "jose@teste", "josé pet");
        Cliente cliente2=new Cliente(02, "José1", 1234, "jose@teste", "josé pet");
        Cliente cliente3=new Cliente(03, "José1", 110, "jose@teste", "josé pet");
        Cliente cliente4=new Cliente(04, "José1", 120, "jose@teste", "josé pet");
        Cliente cliente5=new Cliente(05, "José1", 1567, "jose@teste", "josé pet");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        Fornecedor fornecedor1=new Fornecedor(01, "José1", 78910, "jose@teste");
        Fornecedor fornecedor2=new Fornecedor(02, "José1", 910, "jose@teste");
        Fornecedor fornecedor3=new Fornecedor(03, "José1", 8910, "jose@teste");
        Fornecedor fornecedor4=new Fornecedor(04, "José1", 1910, "jose@teste");
        Fornecedor fornecedor5=new Fornecedor(05, "José1", 110, "jose@teste");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

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
