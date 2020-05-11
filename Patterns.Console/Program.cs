using Patterns.Core.VCS;
using System;

namespace Patterns.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lab 4
            //var configFilePath = Path.Combine(Directory.GetCurrentDirectory(), "repositories.json");
            //var obj = new RepositoryConfigModel() { Id = 2, Path = "124125", Type = 1};

            //string file = File.ReadAllText(configFilePath);
            //List<RepositoryConfigModel> repos = JsonConvert.DeserializeObject<List<RepositoryConfigModel>>(file);

            //repos.Add(obj);

            //string json = JsonConvert.SerializeObject(repos);

            //File.WriteAllText(configFilePath, json);

            //using (FileStream fs = new FileStream(configFilePath
            //                         , FileMode.OpenOrCreate
            //                         , FileAccess.ReadWrite))
            //{
            //    StreamWriter tw = new StreamWriter(fs);
            //    tw.Write(json);
            //    tw.Flush();
            //}


            //string updFile = File.ReadAllText(configFilePath);
            #endregion

            string workingDirectory = @"C:\Users\misha\source\repos\GostBotCore";

            try
            {
                var client = VCSFactory.Create(Core.VCS.Enums.VCSType.Git, workingDirectory);
                //System.Console.WriteLine(client.ChangeCurrentBranch("newBranch"));
                System.Console.WriteLine(client.GetBranches());

                //System.Console.WriteLine(client.DoCommit("test commit"));
                string logs = client.GetLogs(2);
                System.Console.WriteLine(logs);
                System.Console.WriteLine(client.Pull());
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
