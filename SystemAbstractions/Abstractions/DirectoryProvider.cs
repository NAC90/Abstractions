using Abstractions.SystemAbstractions.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace Abstractions.SystemAbstractions.Abstractions;

[ExcludeFromCodeCoverage]
public class DirectoryProvider : IDirectoryProvider
{
    /// <inheritdoc />
    public DirectoryInfo CreateDirectory(string directory)
    {
        return Directory.CreateDirectory(directory);
    }

    /// <inheritdoc />
    public bool Exists(string directory)
    {
        return Directory.Exists(directory);
    }

    /// <inheritdoc />
    public string[] GetDirectories(string directory)
    {
        return Directory.GetDirectories(directory);
    }

    /// <inheritdoc />
    public string[] GetFiles(string directory)
    {
        return Directory.GetFiles(directory);
    }

    /// <inheritdoc />
    public string GetParent(string directory)
    {
        return Directory.GetParent(directory)?.FullName;
    }
}
