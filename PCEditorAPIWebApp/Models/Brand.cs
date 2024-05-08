namespace PCEditorAPIWebApp.Models
{



 
    public class Brand
    {

          public Brand()
       {
           Motherboards = new List<Motherboard>();
           Cases = new List<Case>();
           Cpus = new List<Cpu>();
           CPUCoolers = new List<CPUCooler>();
           Gpus = new List<Gpu>();
           Memories = new List<Memory>();
           PowerSupplies = new List<PowerSupply>();
           Rams = new List<Ram>();
       }
     

        public int Id { get; set; }
        public int Name { get; set; }

        public virtual ICollection<Motherboard> Motherboards { get; set; }
        public virtual ICollection<Case> Cases { get; set; }
        public virtual ICollection<Cpu> Cpus { get; set; }
        public virtual ICollection<CPUCooler> CPUCoolers { get; set; }
        public virtual ICollection<Gpu> Gpus { get; set; }
        public virtual ICollection<Memory> Memories { get; set; }
        public virtual ICollection<PowerSupply> PowerSupplies { get; set; }
        public virtual ICollection<Ram> Rams { get; set; }
    }
}
