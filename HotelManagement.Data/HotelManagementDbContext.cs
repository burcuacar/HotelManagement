using HotelManagement.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Data
{
    public class HotelManagementDbContext : DbContext
    {
        public HotelManagementDbContext(DbContextOptions<HotelManagementDbContext> options) : base(options)
        {

        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
