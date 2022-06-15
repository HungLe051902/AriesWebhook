using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace WebhookDemo.DataAccess
{
	public class WebhookContext : DbContext
	{
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<Post> Posts { get; set; }
		public DbSet<Log> Logs { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(
				@"Data Source = SQL5105.site4now.net; Initial Catalog = db_a880c6_webhook; User Id = db_a880c6_webhook_admin; Password = 12345678@Abc");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Log>()
				.Property(b => b.LogId)
				.ValueGeneratedOnAdd();
		}

		public class Blog
		{
			public int BlogId { get; set; }
			public string Url { get; set; }
			public int Rating { get; set; }
			public List<Post> Posts { get; set; }
		}

		public class Post
		{
			public int PostId { get; set; }
			public string Title { get; set; }
			public string Content { get; set; }

			public int BlogId { get; set; }
			public Blog Blog { get; set; }
		}

		public class Log
		{
			public int LogId { get; set; }
			public string Type { get; set; }
			public string Data { get; set; }
			public DateTime CreatedDate { get; set; } = DateTime.Now;
		}
	}
}
