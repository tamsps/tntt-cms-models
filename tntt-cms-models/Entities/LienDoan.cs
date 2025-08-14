using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TNTT.CMS.Models.Entities
{
	public class LienDoan : BaseAuditableEntity
		{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string TongLienDoanCode { get; set; }
        public string? TenLienDoan { get; set; }
        public string? LienDoanNumber { get; set; }
	    	public string? GiaoPhan { get; set; }
		public TongLienDoan? TongLienDoan { get; set; }
		public ICollection<HiepDoan>? HiepDoans { get; set; }

    }
}

