using System.Collections.Generic;
using WebApplication.Models.Enteties;
using WebApplication.Models.ViewModels;

namespace WebApplication.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        
        void Save(ProductEditViewModel product);
        ProductEditViewModel GetProductEditViewModel();
    }
}