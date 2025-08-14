using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNTT.CMS.Models.Entities
{
		public abstract class BaseAuditableEntity : BaseEntity
		{
				public DateTime CreatedDate { get; set; }

				public string? CreatedBy { get; set; }

				public DateTime? LastModifiedDate { get; set; }

				public string? LastModifiedBy { get; set; }
		}
}
