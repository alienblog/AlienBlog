using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Authorization.Roles;
using Abp.Authorization.Users;
using Abp.Domain.Repositories;

namespace AlienBlog
{
	public class RoleStore : AbpRoleStore<Tenant, Role, User>
	{
		public RoleStore(
			IRepository<Role> roleRepository,
			IRepository<UserRole, long> userRoleRepository,
			IRepository<RolePermissionSetting, long> rolePermissionSettingRepository)
			: base(
				roleRepository,
				userRoleRepository,
				rolePermissionSettingRepository)
		{
		}
	}
}
