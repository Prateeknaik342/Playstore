using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playstore
{
    /*interface name starts with 'I' and we can only declare method declaration, all methods are abstract, 
     cannot create objects for interface and abstract both schould be implimented */
    public interface IUser
    {
        void AddUser();
        void UpdateUser();
        void DeleteUser();
        void GetUser();

    }
}
