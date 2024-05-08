namespace PCEditorAPIWebApp.Models
{
    public class CPUSocket
    {
        public CPUSocket()
        {
            Motherboards = new List<Motherboard>();
            Cpus = new List<Cpu>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Motherboard> Motherboards { get; set; }
        public virtual ICollection<Cpu> Cpus { get; set; }
    }
}
