using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CommandGenerator.Models
{
    public class Enchantment
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please select an enchantment.")]
        public EnchantmentType Type { get; set; }

        [Required(ErrorMessage = "Please select an item.")]
        public ItemType Item { get; set; }

        [Required(ErrorMessage = "Please enter the level of the enchantment.")]
        [Range(1, 10, ErrorMessage = "The level must be between 1 and 10.")]
        public int Level { get; set; }

        [Required(ErrorMessage = "Please enter the creator's name.")]
        [StringLength(50, ErrorMessage = "The creator's name must be less than 50 characters.")]
        public string Creator { get; set; }
    }

    public enum EnchantmentType
    {
        Protection,
        Sharpness,
        Efficiency,
        Power,
        Unbreaking,
        Fortune,
        SilkTouch,
        AquaAffinity,
        Respiration,
        DepthStrider,
        FeatherFalling,
        Flame,
        Infinity,
        LuckOfTheSea,
        Lure,
        Mending,
        FrostWalker,
        CurseOfBinding,
        CurseOfVanishing
    }

    public enum ItemType
    {
        Sword,
        Axe,
        Pickaxe,
        Shovel,
        Hoe,
        Bow,
        Crossbow,
        Trident,
        Helmet,
        Chestplate,
        Leggings,
        Boots,
        Shears,
        FishingRod,
        FlintAndSteel,
        Elytra,
        Shield,
        CarrotOnAStick,
        WarpedFungusOnAStick
    }
}