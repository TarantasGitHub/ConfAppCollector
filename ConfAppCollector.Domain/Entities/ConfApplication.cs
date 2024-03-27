using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfAppCollector.Domain.Entities
{
    public class ConfApplication
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("Author")]
        public Guid Author { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Outline { get; set; }
        public Speaker AuthorApp { get; set; }

    }
}
