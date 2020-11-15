using Comments.Interfaces.ChildRepos;
using Comments.Models.Contexts;
using Comments.Repositories;
using Ninject.Modules;

namespace Comment.BLL.Utils
{
    public class ServiceModule : NinjectModule
    {
        string commentConnectrionString;
        string playerConnectrionString;
        public ServiceModule(string connectrionString1,string connectionString2)
        {
            commentConnectrionString = connectrionString1;
            playerConnectrionString = connectionString2;
        }
        public override void Load()
        {
            Bind<ICommentRepository>().To<CommentRepository>().WithConstructorArgument(new CommentContext(commentConnectrionString));
            Bind<IPlayerRepository>().To<PlayerRepository>().WithConstructorArgument(new PlayersContext(playerConnectrionString));
        }
    }
}
