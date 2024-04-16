using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibrarySystem.Models
{
    public class Borrowing
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime BorrowDate { get; set; }

        [Required]
        public DateTime ReturnDate { get; set; }

        [Required]
        public int BookId { get; set; } // Foreign key property

        [ForeignKey("BookId")]
        public Book Book { get; set; } // Navigation property

        [Required]
        public int MemberId { get; set; } // Foreign key property

        [ForeignKey("MemberId")]
        public Member Member { get; set; } // Navigation property
    }
}
