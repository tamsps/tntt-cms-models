using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TNTT.CMS.Models.Entities
{
	public class TongLienDoan : BaseAuditableEntity
		{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? CountryCode { get; set; }
        public string? TenQuocGia { get; set; }
		public ICollection<LienDoan> LienDoans { get; set; } = new List<LienDoan>();


	}
}

