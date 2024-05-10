using Microsoft.EntityFrameworkCore;


namespace PCEditorAPIWebApp.Models
{
    public class PCEditorAPIContext:DbContext
    {
     
        public virtual DbSet<Case> Cases { get; set; }
        public virtual DbSet<PowerSupply> PowerSupplies { get; set; }
        public virtual DbSet<Motherboard> Motherboards { get; set; }
        public virtual DbSet<Cpu> Cpus { get; set; }
        public virtual DbSet<CPUSocket> CPUSockets { get; set; }
        public virtual DbSet<Gpu> Gpus { get; set; }
        public virtual DbSet<GPUSocket> GPUSockets { get; set; }
        public virtual DbSet<CPUCooler> CPUCoolers { get; set; }
        public virtual DbSet<Ram> Rams { get; set; }
        public virtual DbSet<Memory> Memories { get; set; }
        public virtual DbSet<FormFactor> FormFactors { get; set; }

        public PCEditorAPIContext(DbContextOptions<PCEditorAPIContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }



        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Case>()
                .HasOne(m => m.Brand)
                .WithMany()
                .HasForeignKey(m => m.BrandId);
            modelBuilder.Entity<Case>()
                .HasOne(m => m.PowerSupply)
                .WithMany()
                .HasForeignKey(m => m.PowerSupplyId);
            modelBuilder.Entity<Case>()
                .HasOne(m => m.FormFactor)
                .WithMany()
                .HasForeignKey(m => m.FormFactorId);
            modelBuilder.Entity<Case>()
                .HasOne(m => m.Motherboard)
                .WithMany()
                .HasForeignKey(m => m.MotherboardId);
            modelBuilder.Entity<Case>().HasKey(b => b.Id);




            modelBuilder.Entity<Motherboard>()
                .HasOne(m => m.Brand)
                .WithMany()
                .HasForeignKey(m => m.BrandId);
            modelBuilder.Entity<Motherboard>()
                .HasOne(m => m.FormFactor)
                .WithMany()
                .HasForeignKey(m => m.FormFactorId);
            modelBuilder.Entity<Motherboard>()
                .HasOne(m => m.CPUSocket)
                .WithMany(c => c.Motherboards)
                .HasForeignKey(m => m.CPUSocketId);
            modelBuilder.Entity<Motherboard>()
                .HasOne(m => m.GPUSocket)
                .WithMany()
                .HasForeignKey(m => m.GPUSocketId);
            modelBuilder.Entity<Motherboard>()
                .HasOne(m => m.Cpu)
                .WithMany()
                .HasForeignKey(m => m.CPUId);
            modelBuilder.Entity<Motherboard>()
                .HasOne(m => m.Gpu)
                .WithMany()
                .HasForeignKey(m => m.GPUId);
            modelBuilder.Entity<Motherboard>()
                .HasOne(m => m.Ram)
                .WithMany()
                .HasForeignKey(m => m.RAMId);
            modelBuilder.Entity<Motherboard>()
                .HasOne(m => m.Memory)
                .WithMany()
                .HasForeignKey(m => m.MemoryId);
            modelBuilder.Entity<Motherboard>().HasKey(b => b.Id);




            modelBuilder.Entity<PowerSupply>()
                .HasOne(m => m.Brand)
                .WithMany()
                .HasForeignKey(m => m.BrandId);
            modelBuilder.Entity<PowerSupply>().HasKey(b => b.Id);




            modelBuilder.Entity<Cpu>()
                .HasOne(m => m.Brand)
                .WithMany()
                .HasForeignKey(m => m.BrandId);
            modelBuilder.Entity<Cpu>()
                .HasOne(m => m.CPUSocket)
                .WithMany()
                .HasForeignKey(m => m.CPUSocketId);
            modelBuilder.Entity<Cpu>().HasKey(b => b.Id);




            modelBuilder.Entity<Gpu>()
                .HasOne(m => m.Brand)
                .WithMany()
                .HasForeignKey(m => m.BrandId);
            modelBuilder.Entity<Gpu>()
                .HasOne(m => m.GPUSocket)
                .WithMany()
                .HasForeignKey(m => m.GPUSocketId);
            modelBuilder.Entity<Gpu>()
                .HasOne(m => m.FormFactor)
                .WithMany()
                .HasForeignKey(m => m.FormFactorId);
            modelBuilder.Entity<Gpu>().HasKey(b => b.Id);



            modelBuilder.Entity<CPUCooler>()
                .HasOne(m => m.Brand)
                .WithMany()
                .HasForeignKey(m => m.BrandId);
            modelBuilder.Entity<CPUCooler>().HasKey(b => b.Id);



            modelBuilder.Entity<Ram>()
                .HasOne(m => m.Brand)
                .WithMany()
                .HasForeignKey(m => m.BrandId);
            modelBuilder.Entity<Ram>().HasKey(b => b.Id);



            modelBuilder.Entity<Memory>()
                .HasOne(m => m.Brand)
                .WithMany()
                .HasForeignKey(m => m.BrandId);
            modelBuilder.Entity<Memory>().HasKey(b => b.Id);



            modelBuilder.Entity<Brand>().HasKey(b => b.Id);
            modelBuilder.Entity<FormFactor>().HasKey(b => b.Id);
            modelBuilder.Entity<CPUSocket>().HasKey(b => b.Id);
            modelBuilder.Entity<GPUSocket>().HasKey(b => b.Id);
        }
        
    }
}
