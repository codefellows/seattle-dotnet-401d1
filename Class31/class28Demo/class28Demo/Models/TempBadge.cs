using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace class28Demo.Models
{
    public class TempBadge : AuthorizationHandler<BuildingAccess>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, BuildingAccess requirement)
        {
            return Task.CompletedTask;
        }
    }
}
