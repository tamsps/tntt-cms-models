using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNTT.CMS.Models.Entities
{
	public class Attendance : BaseAuditableEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[ForeignKey("User")]
		public string PIN { get; set; } = string.Empty;

		public DateTime CheckinDateTime { get; set; }
		public DateTime CheckoutDateTime { get; set; }
		public int AttendenceType { get; set; } = 1; // "1": check-in or "0": "check-out"
		public string? Notes { get; set; }

		// Navigation properties
		public Users User { get; set; } = null!;
	}
}
