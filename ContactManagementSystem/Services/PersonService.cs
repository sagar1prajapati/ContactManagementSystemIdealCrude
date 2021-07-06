using ContactManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContactManagementSystem.Context;
using System.Data.SqlClient;
using ContactManagementSystem.ViewModels;
using ContactManagementSystem.Common;
using ContactManagementSystem.Common.Exception;
using ContactManagementSystem.Common.Response;

namespace ContactManagementSystem.Services
{
    public class PersonService : BaseService, IPersonService
    {
        ContactManagementDbContext _db = new ContactManagementDbContext();
        public PersonService()
        {
        }

        #region List
        public PersonContactList_VM List()
        {
            PersonContactList_VM PersonContactList = new PersonContactList_VM();
            try
            {
                #region Process Request 
                SqlParameter Mode = new SqlParameter("@Mode", "LIST");
                PersonContactList.List = _db.Database.SqlQuery<PersonContact_VM>("exec ManagePerson @Mode", Mode).ToList();
                return PersonContactList;
                #endregion
            }
            catch (SqlException SqlException)
            {
                PersonContactList.Error = ExceptionHandler.GetAllFootprints(Constants.SQL_EXCEPTION, Helper.GetCallerClassName(), Helper.GetCallerMethodName(), SqlException);
                PersonContactList.List = new List<PersonContact_VM>();
                PersonContactList.StatusCode = Constants.Fail_STATUS_CODE;
                return PersonContactList;
            }
            catch (Exception ServerException)
            {
                PersonContactList.Error = ExceptionHandler.GetAllFootprints(Constants.GENERIC_EXCEPTION, Helper.GetCallerClassName(), Helper.GetCallerMethodName(), ServerException);
                PersonContactList.List = new List<PersonContact_VM>();
                PersonContactList.StatusCode = Constants.Fail_STATUS_CODE;
                return PersonContactList;
            }
        }
        #endregion
        #region Add
        public Message Add(PersonContact_VM personContact)
        {
            Response response = new Response();
            try
            {
                #region Process Request
                SqlParameter Mode = new SqlParameter("@Mode", "CREATE");
                SqlParameter ID = new SqlParameter("@ID", DbValue(personContact.ID));
                SqlParameter FirstName = new SqlParameter("@FirstName", DbValue(personContact.FirstName));
                SqlParameter MiddleName = new SqlParameter("@MiddleName", DbValue(personContact.MiddleName));
                SqlParameter LastName = new SqlParameter("@LastName", DbValue(personContact.LastName));
                SqlParameter Email = new SqlParameter("@Email", DbValue(personContact.Email));
                SqlParameter PhoneNumber = new SqlParameter("@PhoneNumber", DbValue(personContact.PhoneNumber));
                SqlParameter Status = new SqlParameter("@Status", DbValue(personContact.Status));
                SqlParameter IsDeleted = new SqlParameter("@IsDeleted", DbValue(personContact.IsDeleted));
                
                string result = _db.Database.SqlQuery<string>("exec ManagePerson @Mode ,@ID ,@FirstName ,@MiddleName ,@LastName ,@Email ,@PhoneNumber ,@Status,@IsDeleted ", Mode, ID, FirstName, MiddleName, LastName, Email, PhoneNumber, Status, IsDeleted).FirstOrDefault();
                return response.SuccessMessage(result);
                #endregion
            }
            catch (SqlException SqlException)
            {
                string ErrorMessage = ExceptionHandler.GetAllFootprints(Constants.SQL_EXCEPTION, Helper.GetCallerClassName(), Helper.GetCallerMethodName(), SqlException);
                return response.FailMessage(ErrorMessage);
            }
            catch (Exception ServerException)
            {
               string ErrorMessage = ExceptionHandler.GetAllFootprints(Constants.GENERIC_EXCEPTION, Helper.GetCallerClassName(), Helper.GetCallerMethodName(), ServerException);
               return response.FailMessage(ErrorMessage);
            }
        }
        #endregion
        #region Edit
        public Message Edit(PersonContact_VM personContact)
        {
            Response response = new Response();
            try
            {
                #region Process Request
                SqlParameter Mode = new SqlParameter("@Mode", "UPDATE");
                SqlParameter ID = new SqlParameter("@ID", DbValue(personContact.ID));
                SqlParameter FirstName = new SqlParameter("@FirstName", DbValue(personContact.FirstName));
                SqlParameter MiddleName = new SqlParameter("@MiddleName", DbValue(personContact.MiddleName));
                SqlParameter LastName = new SqlParameter("@LastName", DbValue(personContact.LastName));
                SqlParameter Email = new SqlParameter("@Email", DbValue(personContact.Email));
                SqlParameter PhoneNumber = new SqlParameter("@PhoneNumber", DbValue(personContact.PhoneNumber));
                SqlParameter Status = new SqlParameter("@Status", DbValue(personContact.Status));
                SqlParameter IsDeleted = new SqlParameter("@IsDeleted", DbValue(personContact.IsDeleted));
                string result = _db.Database.SqlQuery<string>("exec ManagePerson @Mode ,@ID ,@FirstName ,@MiddleName ,@LastName ,@Email ,@PhoneNumber ,@Status,@IsDeleted ", Mode, ID, FirstName, MiddleName, LastName, Email, PhoneNumber, Status, IsDeleted).FirstOrDefault();
                return response.SuccessMessage(result);
                #endregion
            }
            catch (SqlException SqlException)
            {
                string ErrorMessage = ExceptionHandler.GetAllFootprints(Constants.SQL_EXCEPTION, Helper.GetCallerClassName(), Helper.GetCallerMethodName(), SqlException);
                return response.FailMessage(ErrorMessage);
            }
            catch (Exception ServerException)
            {
                string ErrorMessage = ExceptionHandler.GetAllFootprints(Constants.GENERIC_EXCEPTION, Helper.GetCallerClassName(), Helper.GetCallerMethodName(), ServerException);
                return response.FailMessage(ErrorMessage);
            }
        }
        #endregion
        #region Delete
        public Message Delete(Int64 id)
        {
            Response response = new Response();
            try
            {
                #region Process Request 
                SqlParameter Mode = new SqlParameter("@Mode", "DELETE");
                SqlParameter ID = new SqlParameter("@ID", DbValue(id));
                string result = _db.Database.SqlQuery<string>("exec ManagePerson @Mode ,@ID", Mode, ID).FirstOrDefault();
                return response.SuccessMessage(result);
                #endregion
            }
            catch (SqlException SqlException)
            {
                string ErrorMessage = ExceptionHandler.GetAllFootprints(Constants.SQL_EXCEPTION, Helper.GetCallerClassName(), Helper.GetCallerMethodName(), SqlException);
                return response.FailMessage(ErrorMessage);
            }
            catch (Exception ServerException)
            {
                string ErrorMessage = ExceptionHandler.GetAllFootprints(Constants.GENERIC_EXCEPTION, Helper.GetCallerClassName(), Helper.GetCallerMethodName(), ServerException);
                return response.FailMessage(ErrorMessage);
            }
        }
        #endregion
    }
}