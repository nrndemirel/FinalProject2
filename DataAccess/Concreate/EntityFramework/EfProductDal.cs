using Entities.Concreate;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities.DTOs;

namespace DataAccess.Concreate.EntityFramework
{
    //NuGet paketiyle geliyor EntityFw
    //using isi bittigi anda garbage collector'u cagirip bellegi temizlemek icin kullanilir. 
    //IDisposible pattern implementatiopn of c# --using
    public class EfProductDal : EntityRepositoryBase<Product, NorthWindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 UnitsInStock = p.UnitsInStock
                             };

                return result.ToList();

            };
        }
    }
}
