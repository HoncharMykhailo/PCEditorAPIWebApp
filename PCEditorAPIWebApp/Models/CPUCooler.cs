﻿namespace PCEditorAPIWebApp.Models
{
    public class CPUCooler
    {
        public CPUCooler()
        {
            Motherbords = new List<Motherboard>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int PowerDemand { get; set; }
        public virtual Brand Brand { get; set; }
        public int BrandId { get; set; }
        public virtual ICollection<Motherboard> Motherbords { get; set; }
    }
}
