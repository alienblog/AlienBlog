using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace AlienBlog
{
	public class Tag : Entity<int>, IHasCreationTime
	{
		public Tag()
		{
			CreationTime = DateTime.Now;
		}

		public virtual Guid UUID { get; set; }

		public virtual string Name { get; set; }

		public virtual string Slug { get; set; }

		public virtual string Description { get; set; }

		public virtual string Image { get; set; }

		public virtual bool Hidden { get; set; }

		public virtual int ParentId { get; set; }

		[ForeignKey("ParentId")]
		public virtual Tag Parent { get; set; }

		public virtual string MetaTitle { get; set; }

		public virtual string MetaDescription { get; set; }


		public virtual DateTime CreationTime { get; set; }

		public virtual long CreatorId { get; set; }

		[ForeignKey("CreatorId")]
		public virtual User Creator { get; set; }

		public virtual IList<Post> Posts { get; set; }
	}
}
