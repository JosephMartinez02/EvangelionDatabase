using System.ComponentModel.DataAnnotations;

namespace EvangelionDatabase.Models
{
    public class Pilot
    {
        public int PilotID {get; set;}
        [Display(Name = "First Name")]
        [Required]
        public string FirstName {get; set;} = string.Empty;
        [Display(Name = "Last Name")]
        [Required]
        public string LastName {get; set;} = string.Empty;
        [Required]
        public string Description {get; set;} = string.Empty;
        public List<PilotEvangelions> PilotEvangelions {get; set;} = default!;
    }

    public class PilotEvangelions
    {
        public int PilotID {get; set;}
        public int EVAID {get; set;}
        public Pilot Pilot {get; set;} = default!;
        public Evangelion Evangelion {get; set;} = default!;
    }
}

