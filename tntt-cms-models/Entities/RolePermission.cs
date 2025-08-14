using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNTT.CMS.Models.Entities
{
	public class RolePermission : BaseAuditableEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[ForeignKey("Role")]
		public int RoleId { get; set; }

		[ForeignKey("Permission")]
		public int PermissionId { get; set; }

		// Navigation properties
		public Role Role { get; set; } = null!;
		public Permission Permission { get; set; } = null!;
	}
}
