using Comment.BLL.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comment.BLL.Models
{
    public class TeamPlayerDTO:IDTO
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CommandName { get; set; }
        public string Position { get; set; }
        public int Weight { get; set; }
        public double Height { get; set; }
        public DateTime Bithday { get; set; }
    }
}
