using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace repository_pattern.Entity
{
    public class Product:IEntity
    {
        public string? Name { get; set; }
        public double Price { get; set; }
        public int Id { get; set; }
    }
}