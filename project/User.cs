using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Domain;

public abstract class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    private int SSN { get; set; }
    public List<IPrivileges>? PrivilegeList { get; set; }
    public IPrivileges? Privileges { get; set; }
}