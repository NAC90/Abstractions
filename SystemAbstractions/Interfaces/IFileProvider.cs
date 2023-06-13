namespace Abstractions.SystemAbstractions.Interfaces
{
    public interface IFileProvider
    {
        bool Exists(string path);

        void Delete(string path);

        Stream OpenRead(string path);

        long GetLength(string path);
    }
}
