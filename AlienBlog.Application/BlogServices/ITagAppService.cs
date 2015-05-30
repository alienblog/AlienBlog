using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;

namespace AlienBlog
{
	public interface ITagAppService : IApplicationService
	{
		IList<Tag> GetTags();
	}
}
