using ApplicationCore.Contracts.RepositoryInterface.Customer.Repository;
using ApplicationCore.Contracts.RepositoryInterface.Order.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Shipping.API.Controllers.Order;

public class OrderController: Controller
{
    protected readonly IOrderRepository _orderRepo ;

    public OrderController(IOrderRepository cu)
    {
        _orderRepo = cu;
    }

    public IActionResult Index()
    {
        var res = _orderRepo.GetAll();
        return View(res);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
}