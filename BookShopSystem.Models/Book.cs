namespace BookShopSystem.Models
{
    using BookShopSystem.Models.Enums;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Book
    {
        // Constructor
        public Book()
        {
        }

        // Properties
        [Key, Range(1, Int32.MaxValue)]
        public int Id { get; set; }

        [StringLength(50), MinLength(1), MaxLength(50), Required]
        public string Title { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        [Required]
        public EditionType EditionType { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required, Range(0, Int32.MaxValue)]
        public int Copies { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}