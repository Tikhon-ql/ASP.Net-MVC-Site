using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Comment.BLL.Validators
{
    public static class Validator
    {
        public static bool IsNicknameCorrect(string nickname)
        {
            string pattern = @"_\w{3}\d{3}";
            Regex regex = new Regex(pattern);
            MatchCollection matchs = regex.Matches(nickname);
            if(matchs.Count < 1)
            {
                return false;
            }
            return true;
        }
    }
}
