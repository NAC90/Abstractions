namespace Abstractions.SystemAbstractions.Interfaces
{
    public interface IPathProvider
    {
        /// <inheritdoc cref="Path.GetExtension(string)" />
        string GetExtension(string path);

        /// <inheritdoc cref="Path.Combine(string[])" />
        string Combine(params string[] paths);

        /// <inheritdoc cref="Path.GetFileNameWithoutExtension(string)" />
        string GetFileNameWithoutExtension(string path);

        /// <inheritdoc cref="Path.GetFullPath(string)"/>
        string GetFullPath(string path);
    }
}
