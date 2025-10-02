// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Internal URI that preserves the original target string while using a rewritten value.
    /// </summary>
    public sealed class OpenXmlUri : Uri
    {
        public OpenXmlUri(string uriString, string original)
            : base(uriString)
        {
            Target = original;
        }

        /// <summary>Original target value as it appeared in the .rels.</summary>
        public string Target { get; }

        /// <summary>The rewritten URI string (same as OriginalString).</summary>
        public string Rewritten => OriginalString;

        public override string ToString() => Target;
    }
}
