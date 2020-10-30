using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Data
{
    public class Entry
    {
        public int ID { get; set; }

        [Required]
        public string Note { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Book { get; set; }

        [Range(1, 200)]
        [Required]
        public int Chapter { get; set; }

        [Range(1, 200)]
        [Required]
        public int Verse { get; set; }

        [Display(Name = "Note Date"), DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime NoteDate { get; set; }
    }
}
