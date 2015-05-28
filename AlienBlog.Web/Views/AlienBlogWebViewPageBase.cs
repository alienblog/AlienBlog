using Abp.Web.Mvc.Views;

namespace AlienBlog.Web.Views
{
    public abstract class AlienBlogWebViewPageBase : AlienBlogWebViewPageBase<dynamic>
    {

    }

    public abstract class AlienBlogWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AlienBlogWebViewPageBase()
        {
            LocalizationSourceName = AlienBlogConsts.LocalizationSourceName;
        }
    }
}