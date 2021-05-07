using repository_pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace repository_pattern.Repositories
{
    public class ProductRepository:Repository<Product>
    {
        public List<Product> getTop(int num)
        {
            return this.GetAll().OrderByDescending(x => x.ID).Take(num).ToList();
        }
        public List<Product> getByOwner(int owner)
        {
            return this.GetAll().Where(x => x.OwnerID == owner).ToList();
        }
    }
}