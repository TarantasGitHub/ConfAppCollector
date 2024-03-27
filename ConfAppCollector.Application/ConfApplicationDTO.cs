using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfAppCollector.Application
{
    public class ConfApplicationDTO
    {
        public Guid Id { get; set; }

        public Guid Author { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Outline { get; set; }
    }
}
