using System.ComponentModel.DataAnnotations;

namespace dojo_survey_validation.Models
{
    public class Ninja
    {
        //Require name field with at least 2 char
        [Display(Name = "Your Name: ")]
        [Required(ErrorMessage = "Please provide a name for new Ninja.")]
        [MinLength(2, ErrorMessage = "Your Ninja's name must be at least 2 characters long.")]
        public string NinjaName { get; set; }


        [Display(Name = "Dojo Location: ")]
        [Required]
        public string DojoLocation { get; set; }


        [Display(Name = "Favorite Language: ")]
        [Required]
        public string FavoriteLanguage  { get; set; }


        [Display(Name = "Comment (optional): ")]
        [MinLength(2, ErrorMessage = "Comments must be at least 20 characters long.")]
        public string Comment { get; set; }


        public Ninja(){}
        public Ninja(string name, string dojo_location, string favorite_language, string comment)
        {
            NinjaName = name;
            DojoLocation = dojo_location;
            FavoriteLanguage = favorite_language;
            Comment = comment;
        }
    }
}