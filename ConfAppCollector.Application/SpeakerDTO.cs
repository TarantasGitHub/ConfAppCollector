using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfAppCollector.Application
{
    public class SpeakerDTO
    {
        public Guid Author { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Outline { get; set; }

        public ConfApplicationDTO ApplicationDTO { get; set; }
    }
}
