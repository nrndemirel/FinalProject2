using DataAccess.Abstract;
using Entities.Concreate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concreate.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product {ProductId = 1, CategoryId = 1, ProductName = "Glass", UnitPrice=15, UnitsInStock= 15 },
                new Product {ProductId = 2, CategoryId = 1, ProductName = "Camera", UnitPrice=15, UnitsInStock= 15 },
                new Product {ProductId = 3, CategoryId = 2, ProductName = "Telephone", UnitPrice=15, UnitsInStock= 15 },
                new Product {ProductId = 4, CategoryId = 2, ProductName = "Keyboard", UnitPrice=15, UnitsInStock= 15 },
                new Product {ProductId = 5, CategoryId = 2, ProductName = "Mouse", UnitPrice=15, UnitsInStock= 15 }
            };
        }
        public void Add(Product product)
        {
             _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product deletedProduct = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            _products.Remove(deletedProduct);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product) 
        {
            Product updatedProduct = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            updatedProduct.UnitPrice = product.UnitPrice;
            updatedProduct.ProductId = product.ProductId;
            updatedProduct.ProductName = product.ProductName;
            updatedProduct.UnitsInStock = product.UnitsInStock;
        }
    }
}
