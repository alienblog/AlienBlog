using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Authorization.Roles;

namespace AlienBlog
{
	public class Role : AbpRole<Tenant, User>
	{
	}
}
