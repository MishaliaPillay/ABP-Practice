using System.ComponentModel.DataAnnotations;

namespace PracticeProject.Configuration.Dto;

public class ChangeUiThemeInput
{
    [Required]
    [StringLength(32)]
    public string Theme { get; set; }
}
