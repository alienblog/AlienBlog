﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace AlienBlog
{
	public class Post:Entity<int>,IHasCreationTime
	{
		public Post()
		{
			CreationTime = DateTime.Now;
		}

		public virtual Guid UUID { get; set; }

		public virtual string Title { get; set; }

		public virtual string Slug { get; set; }

		public virtual string Markdown { get; set; }

		public virtual string Html { get; set; }

		public virtual string Image { get; set; }

		public virtual int Featured { get; set; }

		public virtual int Page { get; set; }

		public virtual PostStatus Status { get; set; }

		public virtual string Language { get; set; }

		public virtual string MetaTitle { get; set; }

		public virtual string MetaDescription { get; set; }

		public virtual long? AuthorId { get; set; }

		[ForeignKey("AuthorId")]
		public virtual User Author { get; set; }

		public virtual long CreatorId { get; set; }

		[ForeignKey("CreatorId")]
		public virtual User Creator { get; set; }

		public virtual DateTime? PublishedAt { get; set; }

		public virtual IList<Tag> Tags { get; set; }

		public virtual DateTime CreationTime { get; set; }
	}
}
