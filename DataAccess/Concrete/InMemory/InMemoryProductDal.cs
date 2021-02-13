using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _product;
        public InMemoryProductDal()
        {
            _product = new List<Product> {
            new Product{ProductId=1,CategoryId=1,ProductName="Bardak", UnitPrice=15 },
            new Product{ProductId=2,CategoryId=1,ProductName="Kalem", UnitPrice=500 },
            new Product{ProductId=3,CategoryId=2,ProductName="Lamba", UnitPrice=1500},
            new Product{ProductId=4,CategoryId=2,ProductName="Kutu", UnitPrice=150},
            new Product{ProductId=5,CategoryId=2,ProductName="Dolap", UnitPrice=85}
            };
        }

        public void Add(Product Product)
        {
            _product.Add(Product);
        }

        public void Delete(Product Product)
        {
            Product productToDelete = null;
            productToDelete = _product.SingleOrDefault(p=>p.ProductId==Product.ProductId);
            _product.Remove(productToDelete);
            
        }

        public List<Product> GetAll()
        {
            return _product;
        }

        public void Update(Product Product)
        {
            Product productToUpdate = _product.SingleOrDefault(p => p.ProductId == Product.ProductId);
            productToUpdate.ProductName = Product.ProductName;
            productToUpdate.CategoryId = Product.CategoryId;
            productToUpdate.UnitPrice = Product.UnitPrice;
            
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _product.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        List<ProductDetailDto> IProductDal.GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
