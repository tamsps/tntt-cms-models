using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TNTT.CMS.Models.Entities
{
				
    public class Role : BaseAuditableEntity
		{
			[Key]
			[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
			public int Id { get; set; } // Đổi từ RoleId sang Id để nhất quán

			[Required]
			[StringLength(50)]
			[Column(TypeName = "NVARCHAR(50)")]
			public string RoleName { get; set; } = string.Empty;

			[StringLength(500)]
			[Column(TypeName = "NVARCHAR(500)")]
			public string? Description { get; set; }

			// Navigation property cho mối quan hệ many-to-many với Users và Permissions
			public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
			public ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
	}
}