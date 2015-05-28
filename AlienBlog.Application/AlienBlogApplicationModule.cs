using System.Reflection;
using Abp.Modules;

namespace AlienBlog
{
    [DependsOn(typeof(AlienBlogCoreModule))]
    public class AlienBlogApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
