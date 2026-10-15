using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNTT.CMS.Models.Entities
{
	public class UserRefreshTokens: BaseAuditableEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[MaxLength(255)]
		public string? PasswordRefeshToken { get; set; }
		
		[MaxLength(255)]
		public string? IP_address { get; set; }

		[MaxLength(255)]
		public string? Expired_at { get; set; }

	}
}
