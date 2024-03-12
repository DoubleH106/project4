using Microsoft.EntityFrameworkCore;
using project4.Models;

namespace project4.Models
{
	public class project4Context : DbContext
	{
		public project4Context(DbContextOptions<project4Context> options) : base(options)
		{

		}
		public DbSet<project4.Models.Account>? Account { get; set; }
		public DbSet<project4.Models.Answer>? Answer { get; set; }
		public DbSet<project4.Models.Categories>? Categories { get; set; }
		public DbSet<project4.Models.Example>? Example { get; set; }
		public DbSet<project4.Models.History>? History { get; set; }
		public DbSet<project4.Models.Lesson>? Lesson { get; set; }
		public DbSet<project4.Models.Question>? Question { get; set; }
		public DbSet<project4.Models.Topic>? Topic { get; set; }
		public DbSet<project4.Models.Word>? Word { get; set; }
		//public DbSet<Accountsss> Accountsss { get; set; }
	}
}

