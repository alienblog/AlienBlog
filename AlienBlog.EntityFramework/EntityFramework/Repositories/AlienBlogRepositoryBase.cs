using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace AlienBlog.EntityFramework.Repositories
{
    public abstract class AlienBlogRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<AlienBlogDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected AlienBlogRepositoryBase(IDbContextProvider<AlienBlogDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class AlienBlogRepositoryBase<TEntity> : AlienBlogRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected AlienBlogRepositoryBase(IDbContextProvider<AlienBlogDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
