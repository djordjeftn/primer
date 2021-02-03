using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProductBusiness
    {
        private readonly ProductRepository productRepository;

        public ProductBusiness()
        {
            this.productRepository = new ProductRepository();
        }
        public bool InsertProducts(Products b)
        {
            if (this.productRepository.InsertProducts(b) > 0)
            {
                return true;
            }
            return false;
        }
        public List<Products> GetAllProducts()
        {
            return this.productRepository.GetAllProducts()
                .Where(b => b.ExpiryDate > DateTime.Today ).ToList();
        }
    }
}
