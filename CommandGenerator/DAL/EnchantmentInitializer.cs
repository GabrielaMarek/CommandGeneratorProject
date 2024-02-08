using CommandGenerator.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CommandGenerator.DAL
{
    public class EnchantmentInitializer : DropCreateDatabaseIfModelChanges<EnchantmentContext>
    {
        protected override void Seed(EnchantmentContext context)
        {

        }
    }
}