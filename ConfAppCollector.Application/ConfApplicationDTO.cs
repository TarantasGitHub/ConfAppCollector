﻿namespace ConfAppCollector.Application
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
