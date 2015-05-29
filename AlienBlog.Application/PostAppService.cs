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
		private readonly IRepository<Post> _postRepository;

		public PostAppService(IRepository<Post> postRepository)
		{
			_postRepository = postRepository;
		}
	}
}
