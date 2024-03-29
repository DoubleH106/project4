﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project4.Models
{
	[Table("HISTORY")]
	public class History
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ID { get; set; }
		public int LessonId { get; set; }
		[StringLength(maximumLength: 20)]
		public string QuantityCorrect { get; set; }
		[StringLength(maximumLength: 100)]
		public string CreatedBy { get; set; }
		[StringLength(maximumLength: 100)]
		public string UpdatedBy { get; set; }
		[StringLength(maximumLength: 100)]
		public string DeletedBy { get; set; }
		public DateTime? CreatedTime { get; set; }
		public DateTime? UpdatedTime { get; set; }
		public DateTime? DeletedTime { get; set; }
		public bool IsDeleted { get; set; }
		public virtual Lesson? Lesson { get; set; }
	}
}
