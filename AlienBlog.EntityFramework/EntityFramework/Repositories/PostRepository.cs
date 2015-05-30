using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFramework;

namespace AlienBlog.EntityFramework.Repositories
{
	public class PostRepository : AlienBlogRepositoryBase<Post, int>, IPostRepository
	{
		public PostRepository(IDbContextProvider<AlienBlogDbContext> dbContextProvider) : base(dbContextProvider)
		{
		}
	}
}
