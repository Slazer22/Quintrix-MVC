using Microsoft.AspNetCore.Identity;

namespace Quintrix_MVC.Models
{
	public class RoleEdit
	{
		public IdentityRole Role { get; set; }
		public IEnumerable<PushinP> Members { get; set; }
		public IEnumerable<PushinP> NonMembers { get; set; }
	}
}