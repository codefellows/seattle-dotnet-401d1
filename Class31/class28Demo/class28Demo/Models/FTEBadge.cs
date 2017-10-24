using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace class28Demo.Models
{
    public class FTEBadge : AuthorizationHandler<BuildingAccess>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, BuildingAccess requirement)
        {
           if(!context.User.HasClaim(c => c.Type == ClaimTypes.Role))
            {
                return Task.CompletedTask;
            }

            if (context.User.HasClaim("FullTimeEmployee", ClaimValueTypes.String))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;

        }
    }
}
