﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project4.Models
{
	[Table("WORD")]
	public class Word
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ID { get; set; }

		[StringLength(maximumLength: 255)]
		public string NameVN { get; set; }
		[StringLength(maximumLength: 255)]
		public string NameEN { get; set; }
		[StringLength(maximumLength: 255)]
		public string Type { get; set; }
		public int TimeStudied { get; set; }
		public bool IsRememory { get;set; }
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
		public virtual ICollection<Example> Examples { get; set; } = new List<Example>();
	}
}
