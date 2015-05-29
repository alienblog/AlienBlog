using System.Reflection;
using Abp.Modules;
using Abp.Zero;

namespace AlienBlog
{
	[DependsOn(typeof(AbpZeroCoreModule))]
    public class AlienBlogCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
