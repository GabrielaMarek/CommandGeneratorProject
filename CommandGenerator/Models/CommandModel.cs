using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommandGenerator.Models
{
    public class CommandModel
    {
        public string CommandType { get; set; }
        public string PlayerName { get; set; }
        public string Item { get; set; }
        public int Quantity { get; set; }
        public List<EnchantmentModel> Enchantments { get; set; }
    }

    public class EnchantmentModel
    {
        public string Enchantment { get; set; }
        public int Level { get; set; }
    }

}