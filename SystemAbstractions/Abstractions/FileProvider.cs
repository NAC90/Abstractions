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
        public byte[] ReadAllBytes(string path)
        {
            return File.ReadAllBytes(path);
        }

        /// <inheritdoc />
        public Stream Create(string path)
        {
            return File.Create(path);
        }

        /// <inheritdoc />
        public void WriteAllText(string filePath, string text)
        {
            File.WriteAllText(filePath, text);
        }

        /// <inheritdoc />
        public void WriteAllBytes(string paths, byte[] data)
        {
            File.WriteAllBytes(paths, data);
        }

        /// <inheritdoc />
        public void Copy(string sourcePath, string destinationPath, bool shouldOverride)
        {
            File.Copy(sourcePath, destinationPath, shouldOverride);
        }

        /// <inheritdoc />
        public void Move(string sourcePath, string destinationPath, bool shouldOverride)
        {
            File.Move(sourcePath, destinationPath, shouldOverride);
        }
    }
}