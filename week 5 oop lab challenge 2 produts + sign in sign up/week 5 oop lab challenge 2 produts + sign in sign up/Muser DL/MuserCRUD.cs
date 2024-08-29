using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week_5_oop_lab_challenge_2_produts___sign_in_sign_up.Muser_Bl;

namespace week_5_oop_lab_challenge_2_produts___sign_in_sign_up.Muser_DL
{
    public class MuserCRUD
    {
        public static bool signin(Muser user, List<Muser>users)
        {
            bool flag = false ;
            for (int idx = 0; idx < users.Count; idx++)
            {
                if (user.username == users[idx].username && user.password == users[idx].password)
                {
                    flag = true;
                    return flag;
                }
            }
            return false;
        }

        public static Muser GetUSer(Muser user, List<Muser> users)
        {

            for (int idx = 0; idx < users.Count; idx++)
            {
                if (user.username == users[idx].username && user.password == users[idx].password)
                {
                    user.role = users[idx].role;
                    return user;
                }
            }
            return null;
        }
    }
}
