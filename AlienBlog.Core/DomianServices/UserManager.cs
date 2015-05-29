using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Authorization.Users;
using Abp.Configuration;
using Abp.Configuration.Startup;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;

namespace AlienBlog
{
	public class UserManager : AbpUserManager<Tenant, Role, User>
	{
		public UserManager(
			UserStore store,
			RoleManager roleManager,
			IRepository<Tenant> tenantRepository,
			IMultiTenancyConfig multiTenancyConfig,
			IPermissionManager permissionManager,
			IUnitOfWorkManager unitOfWorkManager,
			ISettingManager settingManager)
			: base(
				store,
				roleManager,
				tenantRepository,
				multiTenancyConfig,
				permissionManager,
				unitOfWorkManager,
				settingManager)
		{
		}
	}
}
