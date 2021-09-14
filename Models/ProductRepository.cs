using System.Collections.Generic;
using WebApplication.Models.Enteties;
using WebApplication.Models.ViewModels;

namespace WebApplication.Models
{
    public class ProductRepository : IProductRepository

    {

        private MvcDbContext _dbContext;

        public ProductRepository(MvcDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Product> GetAll()
        {
            IEnumerable<Product> products = _dbContext.Products;
            return products;
        }

        public void Save(ProductEditViewModel productEditViewModel)
        {
            Product product = new();
            product.Name = productEditViewModel.Name;
            product.Description = productEditViewModel.Description;
            product.Price = productEditViewModel.Price;
            product.CategoryId = productEditViewModel.CategoryId;
            product.ManufacturerId = productEditViewModel.ManufacturerId;

            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
        }

        public ProductEditViewModel GetProductEditViewModel()
        {
            ProductEditViewModel productEditViewModel = new();

            productEditViewModel.Categories = new List<Category>(_dbContext.Categories);
            productEditViewModel.Manufacturers = new List<Manufacturer>(_dbContext.Manufacturers);

            return productEditViewModel;
        }
    }
}