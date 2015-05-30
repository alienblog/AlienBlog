using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Domain.Repositories;

namespace AlienBlog
{
	public class PostAppService : ApplicationService, IPostAppService
	{
		private readonly IPostRepository _postRepository;

		public PostAppService(IPostRepository postRepository)
		{
			_postRepository = postRepository;
		}
	}
}
