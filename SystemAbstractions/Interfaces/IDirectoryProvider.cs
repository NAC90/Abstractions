namespace Abstractions.SystemAbstractions.Interfaces
{
    public interface IDirectoryProvider
    {
        string[] GetFiles(string directory);

        string[] GetDirectories(string directory);

        string GetParent(string directory);

        bool Exists(string directory);
    }
}
