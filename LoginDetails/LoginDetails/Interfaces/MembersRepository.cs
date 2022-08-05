using LoginDetails.Interfaces;
using LoginDetails.Models;
using System.Collections.Generic;
using System.Linq;

namespace LoginDetails.Interfaces
{
    internal class MembersRepository : ILoginDetails //this should be LoginService : ILoginService

    {
        readonly LoginContext _loginContext;
   

        List<Login_dto> lisMembers = new List<Login_dto>
        {
            new Login_dto{MemberId=1, FirstName="Kirtesh", LastName="Shah", UserName="design@gmail.com",Password="my-super-secret-password1" },
            new Login_dto{MemberId=2, FirstName="Nitya", LastName="Shah", UserName="Vadodara2",Password="my-super-secret-password2" },
            new Login_dto{MemberId=3, FirstName="Dilip", LastName="Shah", UserName="Vadodara3" ,Password="my-super-secret-password3"},
            new Login_dto{MemberId=4, FirstName="Atul", LastName="Shah", UserName="Vadodara4",Password="my-super-secret-password4" },
            new Login_dto{MemberId=5, FirstName="Swati", LastName="Shah", UserName="Vadodara5" ,Password="my-super-secret-password5"},
            new Login_dto{MemberId=6, FirstName="Rashmi", LastName="Shah", UserName="Vadodara6",Password="my-super-secret-password6" },
        };

        public Login_dto Authenticate(string username, string password)
        {
           return lisMembers.FirstOrDefault(x => x.UserName == username && x.Password == password);
        }

        //public Login_dto Forgetpwd(int id, ForGetPasswordModel model)
        //{
        //    throw new System.NotImplementedException();
        //    //var forgtpwd = lisMembers.Any(x => x.UserName == model.Username && x.Password == model.Password);
        //    //if(forgtpwd !=true)
        //    //    return 

        //}

        //public Login_dto Forgetpwd(int id, ForGetPasswordModel model)
        //{
        //    //throw new System.NotImplementedException();
        //    if (lisMembers.Any(x => x.UserName == model.Username && x.Password == model.Password)) ;

        //}

        List<Login_dto> ILoginDetails.GetAllMember()
        {
            return lisMembers;
        }

        Login_dto ILoginDetails.GetMember(int id)
        {
            return lisMembers.FirstOrDefault(x => x.MemberId == id);
        }
    }
}

