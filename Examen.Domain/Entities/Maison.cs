using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Examen.Domain.Entities
{
    public class Maison
    {
        [Key]
        public int maisonId { get; set; }
        public string quartiers { get; set; }
        public double prix { get; set; }
        public int typeFk { get; set; }
        public virtual TypeMaison type { get; set; }
    }
}
