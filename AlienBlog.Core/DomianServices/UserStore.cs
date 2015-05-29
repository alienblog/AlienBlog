﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Authorization.Users;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Runtime.Session;

namespace AlienBlog
{
	public class UserStore : AbpUserStore<Tenant, Role, User>
	{
		public UserStore(
		IRepository<User, long> userRepository,
		IRepository<UserLogin, long> userLoginRepository,
		IRepository<UserRole, long> userRoleRepository,
		IRepository<Role> roleRepository,
		IRepository<UserPermissionSetting, long> userPermissionSettingRepository,
		IAbpSession session,
		IUnitOfWorkManager unitOfWorkManager)
		: base(
			userRepository,
			userLoginRepository,
			userRoleRepository,
			roleRepository,
			userPermissionSettingRepository,
			session,
			unitOfWorkManager)
		{
		}

	}
}
