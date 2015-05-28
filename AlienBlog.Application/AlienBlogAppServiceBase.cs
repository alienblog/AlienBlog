using Abp.Application.Services;

namespace AlienBlog
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class AlienBlogAppServiceBase : ApplicationService
    {
        protected AlienBlogAppServiceBase()
        {
            LocalizationSourceName = AlienBlogConsts.LocalizationSourceName;
        }
    }
}