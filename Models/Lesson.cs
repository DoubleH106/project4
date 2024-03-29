﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project4.Models
{
	[Table("LESSON")]
	public class Lesson
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ID { get; set; }
		public int TopicId { get; set; }

		[StringLength(maximumLength: 100)]
		public string Name { get; set; }
		[StringLength(maximumLength: 500)]
		public string Description { get; set; }
		public int CategoriesId { get; set; }
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

		public virtual Categories? Categories { get; set; }
		public virtual Topic? Topic { get; set; }
		public virtual ICollection<History> Histories { get; set; } = new List<History>();
		public virtual ICollection<Question> Questions { get; set; } = new List<Question>();


	}
}
