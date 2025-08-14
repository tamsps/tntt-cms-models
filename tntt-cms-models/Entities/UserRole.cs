using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNTT.CMS.Models.Entities
{
	public class UserRole : BaseAuditableEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[ForeignKey("User")]
		public string PIN { get; set; } = string.Empty;

		public int RoleId { get; set; } 

		[StringLength(50)]
		[Column(TypeName = "NVARCHAR(50)")]
		public string RoleName { get; set; }

		// Navigation properties
		public Users User { get; set; } = null!;
		public Role Role { get; set; } = null!;
	}
}
