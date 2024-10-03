using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITDepartment_DataAccess.models;
using Microsoft.EntityFrameworkCore;

namespace ITDepartment_DataAccess.Context
{
    public class ITDBContext : DbContext
    {
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Device> Devices { get; set; }
        
        public virtual DbSet<Property> Properties { get; set; }
        public virtual DbSet<PropertyValue> PropertyValues { get; set; }
        public ITDBContext(DbContextOptions<ITDBContext> options) :base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Printer" },
                new Category { Id = 2, Name = "Laptop" },
                new Category { Id = 3, Name = "Desktop" },
                new Category { Id = 4, Name = "Router" },
                new Category { Id = 5, Name = "Switch" },
                new Category { Id = 6, Name = "Monitor" },
                new Category { Id = 7, Name = "Scanner" },
                new Category { Id = 8, Name = "Webcam" },
                new Category { Id = 9, Name = "Server" },
                new Category { Id = 10, Name = "Access Point" }
            );

            // Seed Properties
            modelBuilder.Entity<Property>().HasData(
                new Property { Id = 1, Name = "IP Address", CategoryId = 1 },
                new Property { Id = 2, Name = "Is Color", CategoryId = 1 },
                new Property { Id = 3, Name = "Processor", CategoryId = 2 },
                new Property { Id = 4, Name = "RAM", CategoryId = 2 },
                new Property { Id = 5, Name = "Display", CategoryId = 2 },
                new Property { Id = 6, Name = "Ports", CategoryId = 5 },
                new Property { Id = 7, Name = "Speed", CategoryId = 5 },
                new Property { Id = 8, Name = "Brand", CategoryId = 2 },
                new Property { Id = 9, Name = "Resolution", CategoryId = 6 },
                new Property { Id = 10, Name = "Scanning Resolution", CategoryId = 7 }
            );

            // Seed Devices
            modelBuilder.Entity<Device>().HasData(
                new Device { Id = 1, Name = "HP Printer", AcquisitionDate = DateTime.Now.AddYears(-2), Memo = "Office printer", CategoryId = 1 },
                new Device { Id = 2, Name = "Dell Laptop", AcquisitionDate = DateTime.Now.AddYears(-1), Memo = "Development laptop", CategoryId = 2 },
                new Device { Id = 3, Name = "iMac Desktop", AcquisitionDate = DateTime.Now.AddYears(-3), Memo = "Design workstation", CategoryId = 3 },
                new Device { Id = 4, Name = "Cisco Router", AcquisitionDate = DateTime.Now.AddYears(-1), Memo = "Main office router", CategoryId = 4 },
                new Device { Id = 5, Name = "Netgear Switch", AcquisitionDate = DateTime.Now.AddYears(-1), Memo = "Network switch", CategoryId = 5 },
                new Device { Id = 6, Name = "Samsung Monitor", AcquisitionDate = DateTime.Now.AddYears(-2), Memo = "Office monitor", CategoryId = 6 },
                new Device { Id = 7, Name = "Epson Scanner", AcquisitionDate = DateTime.Now.AddYears(-1), Memo = "Office scanner", CategoryId = 7 },
                new Device { Id = 8, Name = "Logitech Webcam", AcquisitionDate = DateTime.Now.AddYears(-1), Memo = "Video conference webcam", CategoryId = 8 },
                new Device { Id = 9, Name = "Dell Server", AcquisitionDate = DateTime.Now.AddYears(-3), Memo = "Database server", CategoryId = 9 },
                new Device { Id = 10, Name = "TP-Link Access Point", AcquisitionDate = DateTime.Now.AddYears(-1), Memo = "Wi-Fi access point", CategoryId = 10 }
            );

            // Seed PropertyValues
            modelBuilder.Entity<PropertyValue>().HasData(
                new PropertyValue { Id = 1, DeviceId = 1, PropertyId = 1, Value = "192.168.1.100" },
                new PropertyValue { Id = 2, DeviceId = 1, PropertyId = 2, Value = "Yes" },
                new PropertyValue { Id = 3, DeviceId = 2, PropertyId = 3, Value = "Intel i7" },
                new PropertyValue { Id = 4, DeviceId = 2, PropertyId = 4, Value = "16 GB" },
                new PropertyValue { Id = 5, DeviceId = 2, PropertyId = 8, Value = "Dell" },
                new PropertyValue { Id = 6, DeviceId = 3, PropertyId = 8, Value = "Apple" },
                new PropertyValue { Id = 7, DeviceId = 4, PropertyId = 1, Value = "192.168.1.1" },
                new PropertyValue { Id = 8, DeviceId = 5, PropertyId = 6, Value = "24" },
                new PropertyValue { Id = 9, DeviceId = 6, PropertyId = 9, Value = "1920x1080" },
                new PropertyValue { Id = 10, DeviceId = 7, PropertyId = 10, Value = "4800 dpi" }
            );
        }


    }
}
