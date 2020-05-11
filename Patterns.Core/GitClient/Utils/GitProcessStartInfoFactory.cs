using System.Diagnostics;
using System.IO;

namespace Patterns.Core.GitClient.Utils
{
    public static class GitProcessStartInfoFactory
    {
        public static ProcessStartInfo BasicProcessStartInfo()
        {
            return new ProcessStartInfo()
            {
                UseShellExecute = false,
                //todo: get git path from config
                FileName = Path.Combine(@"C:\Program Files\Git\bin", "git.exe"),
                RedirectStandardOutput = true,
            };
        }
    }
}
