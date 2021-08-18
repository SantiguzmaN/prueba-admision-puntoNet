using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.ComponentModel.DataAnnotations;
using ApiPrueba.Context;

namespace ApiPrueba.Models
{
    public class historial
    {
        [Key]
        public int id { get; set; }

        public string ciudad { get; set; }


        public string info { get; set; }


        public void save(string city, string json, AppDbContext context)
        {
            this.ciudad = ciudad;
            this.info = json;

            context.Add(this);
            context.SaveChanges();


        }
    }
}
