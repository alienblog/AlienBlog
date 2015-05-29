using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;

namespace AlienBlog
{
	public class TenantManager : AbpTenantManager<Tenant, Role, User>
	{
		public TenantManager(IRepository<Tenant> tenantRepository)
			: base(tenantRepository)
		{

		}
	}
}
