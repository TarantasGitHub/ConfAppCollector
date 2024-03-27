using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfAppCollector.Domain.Entities
{
    public class Speaker
    {
        [Key]
        public Guid Author {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Outline  { get; set; }
       
        public ConfApplication Application { get; set; }
    }
}
