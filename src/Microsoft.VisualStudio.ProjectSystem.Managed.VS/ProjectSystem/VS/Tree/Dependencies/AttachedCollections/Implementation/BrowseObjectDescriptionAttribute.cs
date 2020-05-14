﻿// Licensed to the .NET Foundation under one or more agreements. The .NET Foundation licenses this file to you under the MIT license. See the LICENSE.md file in the project root for more information.

using System;
using System.Resources;

namespace Microsoft.VisualStudio.ProjectSystem.VS.Tree.Dependencies.AttachedCollections.Implementation
{
    /// <summary>
    /// Specifies a localized description for a property or event.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    internal sealed class BrowseObjectDescriptionAttribute : BrowseObjectDescriptionAttributeBase
    {
        public BrowseObjectDescriptionAttribute(string key) : base(key)
        { }

        protected override ResourceManager ResourceManager => VSResources.ResourceManager;
    }
}