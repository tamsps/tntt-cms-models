using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNTT.CMS.Models.Entities
{
		//create class name PhanDoan under namespace TNTT.CMS.Models.Entities and relative to the class 
			
  	public class PhanDoan : BaseAuditableEntity
		{
				[Key]
				[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
				public int Id { get; set; }
				public string Ten { get; set; }
				public int NganhId { get; set; }
				public ICollection<ChiDoan>? LopHocs { get; set; }
		}
}
