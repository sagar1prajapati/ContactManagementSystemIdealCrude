using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactManagementSystem.ViewModels
{
    //public abstract class T
    //{
    //   public List<T> collectionList { get; set; }
    //   public T Single { get; set; }

    //   public Boolean status { get; set; }
    //   public T SingleError { get; set; }
    //   public List<T> ListError { get; set; }
    //}

    public abstract class BaseModel_VM
    {
       public string Error { get; set; }
       public int StatusCode { get; set; }
    }
}