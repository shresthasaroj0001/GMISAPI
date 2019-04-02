using System.ComponentModel.DataAnnotations;

namespace GMIS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}