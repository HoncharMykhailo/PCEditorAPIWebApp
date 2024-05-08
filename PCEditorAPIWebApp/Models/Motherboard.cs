﻿using System.Runtime.Intrinsics.Arm;

namespace PCEditorAPIWebApp.Models
{

    /*
        ATX,
        MicroATX,
        MiniITX,
        EATX
    */

    public class Motherboard
    {
        public Motherboard()
        {
            Cases = new List<Case>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int PowerDemand { get; set; }
        public int MaxRAMCapacity { get; set; }
        public int MaxRAMSpeed { get; set; }
        public string Chipset { get; set; }
        public virtual FormFactor FormFactor { get; set; }

        public virtual CPUSocket CPUSocket { get; set; } 

        public virtual Brand Brand { get; set; }

        public virtual GPUSocket GPUSocket { get; set; } 

        public virtual Cpu Cpu { get; set; } 

        public virtual Gpu Gpu { get; set; } 

        public virtual Ram Ram { get; set; } 

        public virtual Memory Memory { get; set; } 
       
        public int FormFactorId { get; set; } 
        public int CPUSocketId { get; set; } 
        public int BrandId { get; set; } 
        public int GPUSocketId { get; set; } 
        public int CPUId { get; set; } 
        public int GPUId { get; set; } 
        public int RAMId { get; set; } 
        public int MemoryId { get; set; } 

        public virtual ICollection<Case> Cases { get; set; }

    }
}
