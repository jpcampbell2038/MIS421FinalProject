using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using Uplift.DataAccess.Data.Repository.IRepository;
using Uplift.Models;

namespace Uplift.DataAccess.Data.Repository
{
    public class ProductRepository : Repository<Product> ,  IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetCategoryListForDropDown()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SelectListItem> GetProductListForDropDown()
        {
            return _db.Product.Select(i => new SelectListItem()
            {
                Text = i.ProductName,
                Value = i.Id.ToString()
            });;
        }

        public void Update(Product Product)
        {
            var objFromDb = _db.Product.FirstOrDefault(s => s.Id == Product.Id);

            objFromDb.ProductName = Product.ProductName;
            objFromDb.Cost = Product.Cost;

            _db.SaveChanges();
        }
    }
}
