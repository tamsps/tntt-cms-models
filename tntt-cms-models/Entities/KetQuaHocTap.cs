using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TNTT.CMS.Models.Entities
{
	public class KetQuaHocTap : BaseAuditableEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required] // Giả sử bắt buộc, bạn có thể chỉnh sửa
		[StringLength(50)] // Ví dụ độ dài, chỉnh sửa nếu cần
		[ForeignKey("User")]
		public string PIN { get; set; } = string.Empty;

		[Required]
		[StringLength(50)] // Ví dụ như '2023-2024'
		public string NamHoc { get; set; } = string.Empty;

		[Required]
		[StringLength(50)] 
		public string ChiDoan { get; set; } = string.Empty;

		[Required]
		[StringLength(5)] // Ví dụ như '001'
		public string XuDoanNumber { get; set; } = string.Empty;

		public string GVCN_PIN { get; set; } = string.Empty;
		public double DiemTB { get; set; }
		public string? DiemSoKhac { get; set; }
		public string? KiLuat { get; set; }
		public string? KhenThuong { get; set; }
		public string KetLuan { get; set; } = string.Empty;

		public ICollection<MonHoc>? MonHocs { get; set; } = new List<MonHoc>();

		// Navigation property
		public Users User { get; set; } = null!;
	}
}

