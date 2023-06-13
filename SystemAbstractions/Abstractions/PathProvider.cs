using Abstractions.SystemAbstractions.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace Abstractions.SystemAbstractions.Abstractions
{
    [ExcludeFromCodeCoverage]
    public class PathProvider : IPathProvider
    {
        public string GetExtension(string path)
        {
            return Path.GetExtension(path);
        }
    }
}
