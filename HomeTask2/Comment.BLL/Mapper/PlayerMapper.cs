using Comment.BLL.Models;
using Comments.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comment.BLL.Mapper
{
    public static class PlayerMapper
    {
        public static Player FromDTO(PlayerDTO player)
        {
            Player pl = new Player
            {
                Id = player.Id,
                Name = player.Name,
                Surname = player.Surname,
                Bithday = player.Bithday,
                Position = player.Position,
                CommandName = player.CommandName,
                Height = player.Height,
                Weight = player.Weight,
                ImagePath = player.ImagePath
            };
            return pl;
        }
        public static PlayerDTO ToDTO(Player player)
        {
            PlayerDTO pl = new PlayerDTO
            {
                Id = player.Id,
                Name = player.Name,
                Surname = player.Surname,
                Bithday = player.Bithday,
                Position = player.Position,
                CommandName = player.CommandName,
                Height = player.Height,
                Weight = player.Weight,
                ImagePath = player.ImagePath
            };
            return pl;
        }
        public static List<PlayerDTO> ToDTO(List<Player> players)
        {
            return players.ConvertAll(p => new PlayerDTO
            {
                Id = p.Id,
                Name = p.Name,
                Surname = p.Surname,
                Bithday = p.Bithday,
                Position = p.Position,
                CommandName = p.CommandName,
                Height = p.Height,
                Weight = p.Weight,
                ImagePath = p.ImagePath
            });
        }
        public static List<Player> FromDTO(List<PlayerDTO> players)
        {
            return players.ConvertAll(p => new Player
            {
                Id = p.Id,
                Name = p.Name,
                Surname = p.Surname,
                Bithday = p.Bithday,
                Position = p.Position,
                CommandName = p.CommandName,
                Height = p.Height,
                Weight = p.Weight,
                ImagePath = p.ImagePath
            });
        }
    }
}
