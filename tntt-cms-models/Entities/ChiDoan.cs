using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TNTT.CMS.Models.Entities
{
      
	public class ChiDoan : BaseAuditableEntity
		{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? TenChiDoan { get; set; }
        public int NganhId { get; set; }
        public int PhanDoanId { get; set; }
        public string? NamHoc { get; set; }
        public string? GVCN { get; set; }
		  public string? ChiDoanTruong_PIN { get; set; }
		  public string? NgayHoc { get; set; } //T5, CN
		public ICollection<Users> DanhSach { get; set; }
		
	}
}

