namespace BookShopSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Book
    {
        // Fields
        private ICollection<Category> categories;

        // Constructor
        public Book()
        {
            this.categories = new HashSet<Category>();
        }

        // Properties
        [Key]
        public int Id { get; set; }

        [StringLength(50), MinLength(1), MaxLength(50), Required]
        public string Title { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        [Required]
        public int EditionType { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required, Range(0, Int32.MaxValue)]
        public int Copies { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int AgeRestriction { get; set; }

        public virtual ICollection<Category> Categories
        {
            get
            {
                return this.categories;
            }
            set
            {
                this.categories = value;
            }
        }
    }
}