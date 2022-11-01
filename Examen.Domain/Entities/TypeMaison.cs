using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Examen.Domain.Entities
{
    public class TypeMaison
    {
        [Key]
        public int typeId { get; set; }
        public string type { get; set; }
        public virtual ICollection<Maison> maisons { get; set; }
    }
}
