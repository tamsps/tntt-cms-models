using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TNTT.CMS.Models.Entities
{
	public class XuDoan : BaseAuditableEntity
		{
		    [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
				public string HiepDoanNumber { get; set; }
				public string LienDoanNumber { get; set; }
		public string? XuDoanNumber { get; set; }
		public string? TenXuDoan { get; set; }
				
		public string? GiaoXu { get; set; }        
	}
}

