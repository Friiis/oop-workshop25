using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Domain;

public class UserHandler
{
    private User[] userTypes = new User[]
        {
            new Borrower(),
            new Employee(),
            new Admin()
        };
    public User[] GetUsers()
    {
        return userTypes;
    }
}
