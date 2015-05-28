using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using AlienBlog.EntityFramework;

namespace AlienBlog
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(AlienBlogCoreModule))]
    public class AlienBlogDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<AlienBlogDbContext>(null);
        }
    }
}
