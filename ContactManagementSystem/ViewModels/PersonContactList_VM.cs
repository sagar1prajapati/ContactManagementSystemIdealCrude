using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManagementSystem.ViewModels
{
    public class PersonContactList_VM : BaseModel_VM
    {
        public List<PersonContact_VM> List { get; set; }
    }
}