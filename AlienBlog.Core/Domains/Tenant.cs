using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.MultiTenancy;

namespace AlienBlog
{
	public class Tenant : AbpTenant<Tenant, User>
	{
	}
}
