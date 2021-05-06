﻿using repository_pattern.Models;
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
            List<Product> tm = this.GetAll().OrderByDescending(x => x.ID).Take (num).ToList();
            return tm;

        }
    }
}