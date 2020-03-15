using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RazorApplication.CustomConstraints
{
    public class custom : IRouteConstraint
    {
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if(values[routeKey].ToString().Trim().Length!=0)
            {
                var regex = new Regex("^[a-zA-Z0-9]{4}$");
                if (regex.IsMatch(values[routeKey].ToString()))
                    return true;
            }
            return false;
        }
    }
}
