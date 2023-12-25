namespace Abstractions.SystemAbstractions.Interfaces
{
    public interface IFileProvider
    {
        /// <inheritdoc cref="File.Exists(string)"/>
        bool Exists(string path);

        /// <inheritdoc cref="File.Delete(string)"/>
        void Delete(string path);

        /// <inheritdoc cref="File.Copy(string, string, bool)"/>
        void Copy(string sourcePath, string destinationPath, bool shouldOverride);

        /// <inheritdoc cref="File.Move(string, string, bool)"/>
        void Move(string sourcePath, string destinationPath, bool shouldOverride);

        /// <inheritdoc cref="File.OpenRead(string)"/>
        Stream OpenRead(string path);

        /// <inheritdoc cref="FileInfo.Length"/>
        long GetLength(string path);

        /// <inheritdoc cref="File.ReadAllText(string)"/>
        string ReadAllText(string path);

        /// <inheritdoc cref="File.ReadAllBytes(string)"/>
        byte[] ReadAllBytes(string path);

        /// <inheritdoc cref="File.WriteAllBytes(string, byte[])"/>
        void WriteAllBytes(string paths, byte[] data);

        /// <inheritdoc cref="File.Create(string)"/>
        Stream Create(string path);

        /// <inheritdoc cref="File.WriteAllText(string,string)"/>
        void WriteAllText(string filePath, string text);
    }
}
