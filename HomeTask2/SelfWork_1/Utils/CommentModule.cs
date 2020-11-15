using Comment.BLL.Interfaces.ChildServices;
using Comment.BLL.Services;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SelfWork_1.Utils
{
    public class CommentModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICommentService>().To<CommentService>();
            Bind<IPlayerService>().To<PlayerService>();
        }
    }
}