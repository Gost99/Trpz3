using Patterns.Core.GitClient.Utils;
using System.Diagnostics;

namespace Patterns.Core.GitClient
{
    public class GitClient
    {
        private string _workingDirecory;

        public string WorkingDirectory
        { 
            set 
            {
                _workingDirecory = value;    
            } 
        }

        #region Ctors

        public GitClient(string workingDirectory)
        {
            _workingDirecory = workingDirectory;
        }

        #endregion

        public string ExecuteCommand(string commandText)
        {
            ProcessStartInfo processStartInfo = GitProcessStartInfoFactory.BasicProcessStartInfo();
            processStartInfo.WorkingDirectory = _workingDirecory;
            processStartInfo.Arguments = commandText;
            using (Process exeProcess = Process.Start(processStartInfo))
            {
                string result = exeProcess.StandardOutput.ReadToEnd();
                exeProcess.WaitForExit();
                return result;
            }
        }
    }
}
