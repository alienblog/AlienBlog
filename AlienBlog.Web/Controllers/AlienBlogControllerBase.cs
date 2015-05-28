using Abp.Web.Mvc.Controllers;

namespace AlienBlog.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class AlienBlogControllerBase : AbpController
    {
        protected AlienBlogControllerBase()
        {
            LocalizationSourceName = AlienBlogConsts.LocalizationSourceName;
        }
    }
}