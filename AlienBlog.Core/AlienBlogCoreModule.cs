using System.Reflection;
using Abp.Modules;

namespace AlienBlog
{
    public class AlienBlogCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
