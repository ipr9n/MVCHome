using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using ProductDatabase.DatabaseContext;
using ProductDatabase.DatabaseRepository;

namespace HomeWorkMVC.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Category { get; set; }
    }
}