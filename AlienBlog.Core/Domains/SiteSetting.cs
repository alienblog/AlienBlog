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
	public class SiteSetting : Entity<int>,IHasCreationTime
	{
		public SiteSetting()
		{
			CreationTime = DateTime.Now;
		}

		public virtual Guid UUID { get; set; }

		public virtual string Key { get; set; }

		public virtual string Value { get; set; }

		public virtual SettingType Type { get; set; }


		public virtual DateTime CreationTime { get; set; }

		public virtual long CreatorId { get; set; }

		[ForeignKey("CreatorId")]
		public virtual User Creator { get; set; }
	}
}
