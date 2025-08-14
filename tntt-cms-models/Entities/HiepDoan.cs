using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TNTT.CMS.Models.Entities
{
	public class HiepDoan : BaseAuditableEntity
		{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string LienDoanNumber { get; set; }
		public string? HiepDoanNumber { get; set; }
		public string? TenHiepDoan { get; set; }
        
		public string? GiaoHat { get; set; }
        public ICollection<XuDoan>? XuDoans { get; set; }
    }
}

