using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;

namespace AlienBlog
{
	public class TagAppService : ApplicationService, ITagAppService
	{
		private readonly ITagRepository _tagRepository;

		public TagAppService(ITagRepository tagRepository)
		{
			_tagRepository = tagRepository;
		}

		public IList<Tag> GetTags()
		{
			return _tagRepository.GetAllList();
		}
	}
}
