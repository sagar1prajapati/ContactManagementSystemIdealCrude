using ContactManagementSystem.Common.Response;
using ContactManagementSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManagementSystem.Interfaces
{
    public interface IPersonService
    {
        Message Add(PersonContact_VM personContact);
        Message Edit(PersonContact_VM personContact);
        Message Delete(Int64 id);
        PersonContactList_VM List();
    }
}
