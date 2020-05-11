using Patterns.Core.VCS.Adapters;
using Patterns.Core.VCS.Enums;
using Patterns.Core.VCS.Interfaces;
using System;
using System.Collections.Generic;

namespace Patterns.Core.VCS
{
    public static class VCSFactory
    {
        private static readonly Dictionary<VCSType, Func<string, IVersionControlSystem>> _map = new Dictionary<VCSType, Func<string, IVersionControlSystem>>();

        #region Ctors

        static VCSFactory()
        {
            _map[VCSType.Git] = (directory) => new GitVersionControlSystemAdapter(directory);
            _map[VCSType.Svn] = (directory) => throw new NotImplementedException();
            _map[VCSType.Mercurial] = (directory) => throw new NotImplementedException();
        }

        #endregion

        public static IVersionControlSystem Create(VCSType type, string startDirectory)
        {
            Func<string, IVersionControlSystem> creator;
            _map.TryGetValue(type, out creator); 
            return creator(startDirectory);
        }

    }
}
