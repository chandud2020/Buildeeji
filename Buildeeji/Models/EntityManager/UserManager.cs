using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buildeeji.Models.DB;
using Buildeeji.ViewModel;

namespace Buildeeji.Models.EntityManager
{
    public class UserManager
    {
        public void AddUserAccount( UserSignUpView UserSignUp)
        {
            using (BuildeejiEntities db = new BuildeejiEntities())
            {
                User BEUser = new User();
                BEUser.LoginName = UserSignUp.LoginName;
                BEUser.PasswordEncryptedText  = UserSignUp.Password;
                BEUser.CreatedBY = UserSignUp.UserID > 0 ? UserSignUp.UserID : 1;
                BEUser.UpdatedBy = UserSignUp.UserID > 0 ? UserSignUp.UserID  : 1;
                BEUser.CreatedOn = DateTime.UtcNow;
                BEUser.UpdatedOn = DateTime.UtcNow;
                db.Users.Add(BEUser);
                db.SaveChanges();

                UserProfile BEUserProfile = new UserProfile();
                BEUserProfile.UserID = UserSignUp.UserID;
                BEUserProfile.FirstName = UserSignUp.FirstName;
                BEUserProfile.LastName  = UserSignUp.LastName;
                BEUserProfile.Gender  = UserSignUp.Gender;
                BEUserProfile.FirstName = UserSignUp.FirstName;
                BEUserProfile.CreatedBY = UserSignUp.UserID > 0 ? UserSignUp.UserID : 1;
                BEUserProfile.UpdatedBy = UserSignUp.UserID > 0 ? UserSignUp.UserID : 1;
                BEUserProfile.CreatedOn = DateTime.UtcNow;
                BEUserProfile.UpdatedOn = DateTime.UtcNow;

                db.UserProfiles.Add(BEUserProfile);
                db.SaveChanges();

                if (UserSignUp.RoleID > 0)
                {
                    UserRole BEUserRole = new UserRole();
                    BEUserRole.RoleID = UserSignUp.RoleID;
                    BEUserRole.UserID = UserSignUp.UserID;
                    BEUserRole.IsActive = true;
                    BEUserRole.CreatedBY = UserSignUp.UserID > 0 ? UserSignUp.UserID : 1;
                    BEUserRole.UpdatedBy = UserSignUp.UserID > 0 ? UserSignUp.UserID : 1;
                    BEUserRole.CreatedOn = DateTime.UtcNow;
                    BEUserRole.UpdatedOn = DateTime.UtcNow;

                    db.UserRoles.Add(BEUserRole);
                    db.SaveChanges();

                }
                
            }            
        }

        public bool IsLoginNameExists(string LoginName)
        {
            using (BuildeejiEntities db = new BuildeejiEntities())
            {
                return db.Users.Where(o => o.LoginName.Equals(LoginName)).Any();
            }        
        }
    }
}
