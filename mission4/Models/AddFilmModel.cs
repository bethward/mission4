using System;
using System.ComponentModel.DataAnnotations;

namespace mission4.Models 
{
    public class AddFilmModel
    {
        [Key]
        [Required]
        public int AppId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public ushort Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string Lent { get; set; }
        public string Notes { get; set; }

        //building foreign key relationship
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }

}