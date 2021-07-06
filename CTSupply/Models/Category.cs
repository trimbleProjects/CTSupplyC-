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
    [Table("Products")]
    public class Category 
    {
        public string Partnum { get; set; }


    }
    public class Product : DbContext
    {
        public DbSet<Category> products { get; set; }
    }
}