using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.EntityFramework;
using AlienBlog.Repositories;

namespace AlienBlog.EntityFramework.Repositories
{
	public class SiteSettingRepository : AlienBlogRepositoryBase<SiteSetting, int>, ISiteSettingRepository
	{
		public SiteSettingRepository(IDbContextProvider<AlienBlogDbContext> dbContextProvider) : base(dbContextProvider)
		{
		}
	}
}
