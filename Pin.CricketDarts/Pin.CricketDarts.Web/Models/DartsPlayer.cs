using System.ComponentModel.DataAnnotations;

namespace Pin.CricketDarts.Web.Models
{
    public class DartsPlayer : BaseModel
    {
        [Required(ErrorMessage = "Please provide a {0}")]
        [MinLength(2,ErrorMessage ="{0} must have a length of minimum {1}")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please provide a {0}")]
        [MinLength(2, ErrorMessage = "{0} must have a length of minimum {1}")]
        public string LastName { get; set; }
        public int Score { get; set; }
        public List<ThrowModel> Throws { get; set; }
        public bool IsActiveTurn { get; set; }
    }
}

