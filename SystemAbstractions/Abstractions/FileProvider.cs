using Abstractions.SystemAbstractions.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace Abstractions.SystemAbstractions.Abstractions
{
    [ExcludeFromCodeCoverage]
    public class FileProvider : IFileProvider
    {
        /// <inheritdoc />
        public void Delete(string path)
        {
            File.Delete(path);
        }

        /// <inheritdoc />
        public bool Exists(string path)
        {
            return File.Exists(path);
        }

        /// <inheritdoc />
        public Stream OpenRead(string path)
        {
            return File.OpenRead(path);
        }

        /// <inheritdoc />
        public long GetLength(string path)
        {
            return new FileInfo(path).Length;
        }

        /// <inheritdoc />
        public string ReadAllText(string path)
        {
            return File.ReadAllText(path);
        }

        /// <inheritdoc />
        public Stream Create(string path)
        {
            return File.Create(path);
        }
    }
}