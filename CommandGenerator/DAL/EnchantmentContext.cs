using CommandGenerator.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CommandGenerator.DAL
{
    public class EnchantmentContext : DbContext
    {
        public DbSet<Enchantment> Enchantments { get; set; }
        public DbSet<Comment> Comments { get; set; }


        public EnchantmentContext() : base("name=EnchantmentContext") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}