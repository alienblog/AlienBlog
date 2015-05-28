using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace AlienBlog
{
    [DependsOn(typeof(AbpWebApiModule), typeof(AlienBlogApplicationModule))]
    public class AlienBlogWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(AlienBlogApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
