namespace BookShopSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Category
    {
        // Constructor
        public Category()
        {
        }

        // Properties
        [Key, Range(1, Int32.MaxValue)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}