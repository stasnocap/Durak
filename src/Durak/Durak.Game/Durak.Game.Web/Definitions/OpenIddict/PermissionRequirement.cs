﻿using Microsoft.AspNetCore.Authorization;

namespace Durak.Game.Web.Definitions.OpenIddict
{
    /// <summary>
    /// Permission requirement for user or service authorization
    /// </summary>
    public class PermissionRequirement : IAuthorizationRequirement
    {
        public PermissionRequirement(string permissionName) => PermissionName = permissionName;

        /// <summary>
        /// Permission name
        /// </summary>
        public string PermissionName { get; }
    }
}