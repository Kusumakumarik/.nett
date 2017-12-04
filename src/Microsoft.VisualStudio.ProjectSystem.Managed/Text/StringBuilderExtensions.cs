﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System.Text;

namespace Microsoft.VisualStudio.Text
{
    /// <summary>
    ///     Provides extension methods for <see cref="StringBuilder"/> instances.
    /// </summary>
    internal static class StringBuilderExtensions
    {
        /// <summary>
        ///     Appends the text representation of the specified format to the
        ///     specified string builder.
        /// </summary>
        /// <exception cref="ArgumentNullException">
        ///     <paramref name="builder"/> is <see langword="null"/>.
        /// </exception>
        /// <exception cref="FormatException">
        ///     The format specification in <paramref name="format"/> is invalid.
        /// </exception>
        public static void AppendFormat(this StringBuilder builder, StringFormat format)
        {
            Requires.NotNull(builder, nameof(builder));

            int length = format.Length;

            if (length == 0)
            {
                builder.Append(format.Format);
            }
            else if (length == 1)
            {
                builder.AppendFormat(format.Format, format.Argument1);
            }
            else if (length == 2)
            {
                builder.AppendFormat(format.Format, format.Argument1, format.Argument2);
            }
            else if (length == 3)
            {
                builder.AppendFormat(format.Format, format.Argument1, format.Argument2, format.Argument3);
            }
            else
            {
                builder.AppendFormat(format.Format, format.Arguments);
            }
        }
    }
}
