using LoginDetails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginDetails.Interfaces
{
    interface ILoginDetails
    {
        List<Login_dto> GetAllMember();
        Login_dto GetMember(int id);
     
        Login_dto Authenticate(string username, string password);
        //Login_dto Forgetpwd(int id, ForGetPasswordModel model);
    }
}
