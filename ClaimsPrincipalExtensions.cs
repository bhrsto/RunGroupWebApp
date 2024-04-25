﻿using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace RunGroupWebApp
{
    public static class ClaimsPrincipalExtensions
    {
        public static string GerUserId(this ClaimsPrincipal user)
        {
            return user.FindFirst(ClaimTypes.NameIdentifier).Value; 
        }
    }
}
