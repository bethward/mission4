using System;
using System.ComponentModel.DataAnnotations;

namespace mission4.Models 
{
    public class AddFilm
    {
        [Key]
        [Required]
        public int AppId { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public ushort Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string Lent { get; set; }
        public string Notes { get; set; }
    }

}