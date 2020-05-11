using Patterns.Core.GitClient.Consts;
using Patterns.Core.VCS.Interfaces;
using System;

namespace Patterns.Core.VCS.Adapters
{
    public class GitVersionControlSystemAdapter : IVersionControlSystem
    {
        private readonly GitClient.GitClient _gitClient;

        #region Ctors

        public GitVersionControlSystemAdapter(string startWorkingDirectory)
        {
            _gitClient = new GitClient.GitClient(startWorkingDirectory);
        }

        #endregion

        public void ChangeWorkingDirectory(string newWorkingDirectory)
        {
            _gitClient.WorkingDirectory = newWorkingDirectory;
        }

        #region VCS Implementation

        public string ChangeCurrentBranch(string branchName)
        {
            return _gitClient.ExecuteCommand($"{GitCommands.Checkout} {branchName}");
        }

        public string CreateBranch(string name)
        {
            return _gitClient.ExecuteCommand($"{GitCommands.Branch} {name}");
        }

        public string CreateTag(string tagName)
        {
            return _gitClient.ExecuteCommand($"{GitCommands.Tag} -a {tagName}");
        }

        public string DoCommit(string commitMessage)
        {
            return _gitClient.ExecuteCommand($"{GitCommands.Commit} -m \"{commitMessage}\"");
        }

        public string DoFetch(string remoteName)
        {
            return _gitClient.ExecuteCommand($"{GitCommands.Fetch} {remoteName}");
        }

        public string DoMerge(string targetBranchName, string mergeCandidateBranchName)
        {
            string result = String.Empty;
            result += ChangeCurrentBranch(targetBranchName);
            result += _gitClient.ExecuteCommand($"{GitCommands.Merge} {mergeCandidateBranchName}");
            return result;
        }

        public string GetBranches()
        {
            return _gitClient.ExecuteCommand(GitCommands.Branch);
        }

        public string GetLogs(int? logsCount)
        {
            string commandText = logsCount.HasValue ? $"{GitCommands.Log} -{logsCount.Value}" : GitCommands.Log;
            return _gitClient.ExecuteCommand(commandText);
        }

        public string InitRepository(string repositoryName)
        {
            return _gitClient.ExecuteCommand(GitCommands.Init);
        }

        public string Pull()
        {
            return _gitClient.ExecuteCommand(GitCommands.Pull);
        }

        public string Push(string remoteName, string branchName)
        {
            return _gitClient.ExecuteCommand($"{GitCommands.Push} {remoteName} {branchName}");
        }

        #endregion

    }
}
