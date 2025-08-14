using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TNTT.CMS.Models.Entities
{
	public class Users : BaseAuditableEntity
		{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[Required]
		[StringLength(50)] // Match KetQuaHocTap.PIN length
		[Column(TypeName = "NVARCHAR(50)")] // Explicit
		public string PIN { get; set; } = string.Empty; //The id will be generate unique in whole system
		public string TenThanh { get; set; } = string.Empty;
		public string Ho { get; set; } = string.Empty;
		public string Ten { get; set; } = string.Empty;
		public string XuDoanNumber { get; set; }
		public string? ImageSmallUri { get; set; }
		public string? ImageLargeUri { get; set; }
		public string? GioiTinh { get; set; }
		public DateTime? NgaySinh { get; set; }
		public DateTime? NgayRuaToi { get; set; }
		public DateTime? NgayThemSuc { get; set; }
		public string? DiaChi { get; set; }
		public string? TenCha { get; set; }
		public string? TenMe { get; set; }
		public string SoDT1 { get; set; } = string.Empty;
		public string? SoDT2 { get; set; }
		public string? NhanXet { get; set; }
		public int Type { get; set; }// 1: Huynh trương; 2: Thieu Nhi; 3: Khac

		[MaxLength(255)]
		public string? PasswordHash { get; set; } // Nullable string '?' makes it optional

		[MaxLength(255)]
		public string? PasswordResetToken { get; set; }

		public DateTime? PasswordResetExpires { get; set; } // Nullable DateTime '?' is inherently optional

		public DateTime? LastLoginDate { get; set; }
		public int FailedLoginAttempts { get; set; } = 0;


		// Navigation properties cho many-to-many với Roles
		public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();

		// Navigation properties cho các model khác
		public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();
		public ICollection<KetQuaHocTap> KetQuaHocTaps { get; set; } = new List<KetQuaHocTap>();

	}
}

