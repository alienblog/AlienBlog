using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFramework;

namespace AlienBlog.EntityFramework.Repositories
{
	public class TagRepository : AlienBlogRepositoryBase<Tag, int>, ITagRepository
	{
		public TagRepository(IDbContextProvider<AlienBlogDbContext> dbContextProvider) : base(dbContextProvider)
		{
		}
	}
}
