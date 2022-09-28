﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Entities
{
    public class AuthorBook
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}
