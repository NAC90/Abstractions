namespace Abstractions.SystemAbstractions.Interfaces
{
    public interface IDirectoryProvider
    {
        /// <inheritdoc cref="Directory.GetFiles(string)"/>
        string[] GetFiles(string directory);

        /// <inheritdoc cref="Directory.GetDirectories(string)" />
        string[] GetDirectories(string directory);

        /// <inheritdoc cref="Directory.GetParent(string)"/>
        string GetParent(string directory);

        /// <inheritdoc cref="Directory.Exists(string)" />
        bool Exists(string directory);

        /// <inheritdoc cref="Directory.CreateDirectory(string)"/>
        DirectoryInfo CreateDirectory(string directory);
    }
}
