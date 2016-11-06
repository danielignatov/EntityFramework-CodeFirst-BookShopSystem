namespace BookShopSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Author
    {
        // Fields
        private ICollection<Book> books;

        // Constructor
        public Author()
        {
            this.Books = new HashSet<Book>();
        }

        // Properties
        [Key, Range(1, Int32.MaxValue)]
        public int Id;

        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [NotMapped]
        public virtual ICollection<Book> Books
        {
            get
            {
                return this.books;
            }
            set
            {
                this.books = value;
            }
        }
    }
}