using System.Data.Entity;
using Abp.EntityFramework;

namespace AlienBlog.EntityFramework
{
	public class AlienBlogDbContext : AbpDbContext
	{
		//TODO: Define an IDbSet for each Entity...

		//Example:
		//public virtual IDbSet<User> Users { get; set; }
		public virtual IDbSet<Post> Posts { get; set; } 

		/* NOTE: 
		 *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
		 *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
		 *   pass connection string name to base classes. ABP works either way.
		 */
		public AlienBlogDbContext()
			: base("Default")
		{

		}

		/* NOTE:
		 *   This constructor is used by ABP to pass connection string defined in AlienBlogDataModule.PreInitialize.
		 *   Notice that, actually you will not directly create an instance of AlienBlogDbContext since ABP automatically handles it.
		 */
		public AlienBlogDbContext(string nameOrConnectionString)
			: base(nameOrConnectionString)
		{

		}
	}
}
