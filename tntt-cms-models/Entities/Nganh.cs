using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNTT.CMS.Models.Entities
{
		//create class name Nganh under namespace TNTT.CMS.Models.Entities and relative to the class XuDoan

 		public class Nganh : BaseAuditableEntity
		{
				[Key]
				[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
				public int Id { get; set; }
			[StringLength(50)]
			[Column(TypeName = "NVARCHAR(50)")]
		public string Ten { get; set; }
				public int XuDoanId { get; set; }
				public ICollection<PhanDoan>? PhanDoan { get; set; }

		}
}
