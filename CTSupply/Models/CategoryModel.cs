using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace CTSupply.Models
{
    public class CategoryModel 
    {
        public string partnum { get; set; }


    }
    public class Product : DbContext
    {
        public DbSet<CategoryModel> prodCategory { get; set; }
    }
}