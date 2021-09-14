using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;
using WebApplication.Models.Enteties;
using WebApplication.Models.ViewModels;

namespace WebApplication.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        // GET
        public IActionResult Index()
        {
            IEnumerable<Product> products = _repository.GetAll();

            return View(products);
        }

        //GET: Product/Create
        [HttpPost]
        public IActionResult Create([Bind("Name,Description,Price,ManufacturerId,CategoryId")]
            ProductEditViewModel product)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    TempData["message"] = "Ugylige felt";
                    return RedirectToAction("Create");
                }
                // Kall til metoden save i repository
                _repository.Save(product);
                TempData["message"] = string.Format("{0} har blitt opprettet", product.Name);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: Product/Create
        public ActionResult Create()
        {
            var product = _repository.GetProductEditViewModel();
            
            return View(product);
        }
        
    }
}