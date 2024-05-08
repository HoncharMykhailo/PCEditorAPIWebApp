namespace PCEditorAPIWebApp.Models
{
    public class Cpu
    {

        public Cpu()
        {
            Motherboards = new List<Motherboard>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int PowerDemand { get; set; }
        public int Speed { get; set; }
        public int Ncores { get; set; }
        public int MaxRAMCapacity { get; set; }
        public virtual CPUSocket CPUSocket { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual ICollection<Motherboard> Motherboards { get; set; }


        public int CPUSocketId { get; set; }
        public int BrandId { get; set; }
    }
}
