using ApplicationCore.Contracts.RepositoryInterface.ProductIRepo;
using ApplicationCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Shipping.API.Controllers.Product;

public class ProductController: Controller
{
    protected readonly IProductRepository _prodRep ;
    public ProductController(IProductRepository repo)
    {
        _prodRep = repo;
    }
    
    public IActionResult Index()
    {
        var content = _prodRep.GetAll();
        return View(content);
    }
    
    [HttpPost]
    public IActionResult Create(ApplicationCore.Entities.Product obj)
    {
        if (ModelState.IsValid)
        {
            try
            {
                _prodRep.Insert(obj);
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
        var entity = _prodRep.GetById(id);
        return View(entity);
    }
    
    [HttpPost]
    public IActionResult Delete(ApplicationCore.Entities.Product obj)
    {
        _prodRep.Delete(obj.Id);
        return RedirectToAction("Index");
    }
    
    [HttpGet]
    public IActionResult Edit(int id)
    {
        var entity = _prodRep.GetById(id);
        return View(entity);
    }
    
    [HttpPost]
    public IActionResult Edit(ApplicationCore.Entities.Product obj)
    {
        try {
            
            _prodRep.Update(obj);
            return RedirectToAction("Index");
        }
        catch (Exception ex)
        {
            return View(obj);
        }
    }
    
    // public IActionResult AddToBag()
    // {
    //     var content = prodRep.GetAll();
    //     return View(content);
    // }
    
    
}