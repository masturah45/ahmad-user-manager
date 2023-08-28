using System.ComponentModel.DataAnnotations;

public class AddRoleViewModel
{
    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
}
