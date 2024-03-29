﻿using Abstractions.SystemAbstractions.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace Abstractions.SystemAbstractions.Abstractions
{
    [ExcludeFromCodeCoverage]
    public class PathProvider : IPathProvider
    {
        /// <inheritdoc />
        public string Combine(params string[] paths)
        {
            return Path.Combine(paths);
        }

        /// <inheritdoc />
        public string GetExtension(string path)
        {
            return Path.GetExtension(path);
        }

        /// <inheritdoc />
        public string GetFileNameWithoutExtension(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }

        /// <inheritdoc />
        public string GetFullPath(string path)
        {
            return Path.GetFullPath(path);
        }
    }
}
