using System.IO.Abstractions;

namespace Automatize.FileFinders
{
    public class EnvironmentFileFinder : FileFinder, IFileFinder
    {
        public EnvironmentFileFinder(IFileSystem fileSystem) : base(fileSystem, "*.env")
        { }
    }
}