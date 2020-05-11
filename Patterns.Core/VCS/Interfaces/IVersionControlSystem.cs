namespace Patterns.Core.VCS.Interfaces
{
    public interface IVersionControlSystem
    {
        string InitRepository(string repositoryName);

        string CreateBranch(string name);

        string GetBranches();

        string ChangeCurrentBranch(string branchName);

        string DoCommit(string commitMessage);

        string DoFetch(string remoteName);

        string GetLogs(int? logsCount);

        string DoMerge(string targetBranchName, string mergeCandidateBranchName);

        string Pull();

        string Push(string remoteName, string branchName);

        string CreateTag(string tagName);
    }
}
