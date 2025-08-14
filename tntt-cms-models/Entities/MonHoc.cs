using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TNTT.CMS.Models.Entities
{
	public class MonHoc : BaseAuditableEntity
		{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string PIN { get; set; }
        public string? TenMon { get; set; }
        public double Diem { get; set; }
        public int KetQuaHocTapId { get; set; }
        public string? GhiChu { get; set; }
		    public KetQuaHocTap KetQuaHocTap { get; set; } = null!;  // Navigation ngược
	}
}

