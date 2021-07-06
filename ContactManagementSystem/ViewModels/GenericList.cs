using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManagementSystem.ViewModels
{
    public class GenericList<T> : BaseModel_VM
    {
       public List<T> List { get; set; }
    }
}