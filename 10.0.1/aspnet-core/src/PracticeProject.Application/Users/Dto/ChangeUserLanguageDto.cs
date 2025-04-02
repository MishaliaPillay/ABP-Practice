using System.ComponentModel.DataAnnotations;

namespace PracticeProject.Users.Dto;

public class ChangeUserLanguageDto
{
    [Required]
    public string LanguageName { get; set; }
}