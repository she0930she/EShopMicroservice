using ApplicationCore.Contracts.RepositoryInterface.Customer.Repository;
using Microsoft.AspNetCore.Mvc;


namespace Shipping.API.Controllers.Customer;

public class CustomerController: Controller
{
    protected readonly ICustomerRepo _customerRepo ;

    public CustomerController(ICustomerRepo cu)
    {
        _customerRepo = cu;
    }

    public IActionResult Index()
    {
        var res = _customerRepo.GetAll();
        return View(res);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(ApplicationCore.Entities.Customer obj)
    {
        if (ModelState.IsValid)
        {
            try
            {
                _customerRepo.Insert(obj);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(obj);
            }
        }
        return View(obj);
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var entity = _customerRepo.GetById(id);
        return View(entity);
    }
    
    [HttpPost]
    public IActionResult Delete(ApplicationCore.Entities.Customer obj)
    {
        _customerRepo.Delete(obj.Id);
        return RedirectToAction("Index");
    }
    
    [HttpGet]
    public IActionResult Edit(int id)
    {
        var entity = _customerRepo.GetById(id);
        return View(entity);
    }
    
    [HttpPost]
    public IActionResult Edit(ApplicationCore.Entities.Customer obj)
    {
        try {
            
            _customerRepo.Update(obj);
            return RedirectToAction("Index");
        }
        catch (Exception ex)
        {
            return View(obj);
        }
    }
}