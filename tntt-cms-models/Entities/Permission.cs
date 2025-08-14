using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNTT.CMS.Models.Entities
{
	public class Permission : BaseAuditableEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; } // Đổi từ PermissionId sang Id để nhất quán

		[Required]
		[StringLength(50)]
		[Column(TypeName = "NVARCHAR(50)")]
		public string PermissionName { get; set; } = string.Empty;

		[StringLength(255)]
		[Column(TypeName = "NVARCHAR(255)")]
		public string? Description { get; set; }

		public ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
	}
}
