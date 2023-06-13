using Abstractions.SystemAbstractions.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace Abstractions.SystemAbstractions.Abstractions;

[ExcludeFromCodeCoverage]
public class DirectoryProvider : IDirectoryProvider
{
    public bool Exists(string directory)
    {
        return Directory.Exists(directory);
    }

    public string[] GetDirectories(string directory)
    {
        return Directory.GetDirectories(directory);
    }

    public string[] GetFiles(string directory)
    {
        return Directory.GetFiles(directory);
    }

    public string GetParent(string directory)
    {
        return Directory.GetParent(directory)?.FullName;
    }
}
