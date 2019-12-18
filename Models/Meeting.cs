using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingPlanner.Models
{
    public class Meeting
    {
        public int ID { get; set; }

        [Display(Name = "Meeting Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime SpeechDate { get; set; }
        [Required]
        public string Topic { get; set; }

        [StringLength(60, MinimumLength = 2)]
        [RegularExpression("^[a-zA-Z0-9 '-]*$", ErrorMessage = "Enter name using only letters, apostrophe or hyphen")]
        [Display(Name = "Conducting Leader")]
        [Required]
        public string ConductingLeader { get; set; }
        [Required]
        public string OpeningSong { get; set; }
        [StringLength(60, MinimumLength = 2)]
        [RegularExpression("^[a-zA-Z0-9 '-]*$", ErrorMessage = "Enter name using only letters, apostrophe or hyphen")]
        [Display(Name = "Opening Prayer")]
        [Required]
        public string OpeningPrayer { get; set; }
        [Display(Name = "Sacrament Song")]
        [Required]
        public string SacramentSong { get; set; }
        [Display(Name = "Speaker")]
        [StringLength(120, MinimumLength = 2)]
        [RegularExpression("^[a-zA-Z0-9 '-]*$", ErrorMessage = "Enter Name using only letters, apostrophe or hyphen")]
        public string Speaker1 { get; set; }
        [Display(Name = "Speaker")]
        [StringLength(120, MinimumLength = 2)]
        [RegularExpression("^[a-zA-Z0-9 '-]*$", ErrorMessage = "Enter Name using only letters, apostrophe or hyphen")]
        public string Speaker2 { get; set; }
        [Display(Name = "Speaker")]
        [StringLength(120, MinimumLength = 2)]
        [RegularExpression("^[a-zA-Z0-9 '-]*$", ErrorMessage = "Enter Name using only letters, apostrophe or hyphen")]
        public string Speaker3 { get; set; }
        [Display(Name = "Speaker")]
        [StringLength(120, MinimumLength = 2)]
        [RegularExpression("^[a-zA-Z0-9 '-]*$", ErrorMessage = "Enter Name using only letters, apostrophe or hyphen")]
        public string Speaker4 { get; set; }
        [Display(Name = "Speaker")]
        [StringLength(120, MinimumLength = 2)]
        [RegularExpression("^[a-zA-Z0-9 '-]*$", ErrorMessage = "Enter Name using only letters, apostrophe or hyphen")]
        public string Speaker5 { get; set; }
        [Display(Name = "Closing Song")]
        [Required]
        public string ClosingSong { get; set; }
        [StringLength(60, MinimumLength = 2)]
        [RegularExpression("^[a-zA-Z0-9 '-]*$", ErrorMessage = "Enter name using only letters, apostrophe or hyphen")]
        [Display(Name = "Closing Prayer")]
        [Required]
        public string ClosingPrayer { get; set; }


    }


}
