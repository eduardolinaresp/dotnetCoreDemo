using Hangfire.Annotations;
using Hangfire.Dashboard;
using System.Security.Claims;

namespace HangfireDemo
{
    public class HangfireDashboardAuthorizationFilter : IDashboardAuthorizationFilter
    {
       
       public bool Authorize([NotNull] DashboardContext context)
        {
            var httpcontext = context.GetHttpContext();
            var userRole = httpcontext.User.FindFirst(ClaimTypes.Role)?.Value;

            //return userRole == AppRoles.WebMaster;
            return userRole == "WebMaster";
            //return true;

        }


    }
}