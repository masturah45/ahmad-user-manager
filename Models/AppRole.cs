using Microsoft.AspNetCore.Identity;

namespace asdf.Models;

public class AppRole : IdentityRole
{
    public AppRole(string name) : base(name)
    {
    }
    public string Description { get; set; }
}
