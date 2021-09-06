using Shop.Core.DTOs;
using Shop.DataLayer.Entities.User;
using Shop.DataLayer.Entities.Wallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.Services.Interfaces
{
    public interface IUserService
    {
        bool IsExistUserName(string userName);
        bool IsExistEmail(string email);
        int AddUser(User user);
        User LoginUser(LoginViewModel login);
        User GetUserByEmail(string email);
        User GetUserByUserName(string userName);
        User GetUserById(int userId);
        User GetUserByActiveCode(string activeCode);
        void UpdateUser(User user);
        bool ActiveAccount(string activeCode);
        List<User> GetAllUsers();
        int GetUserIdByUserName(string userName);
        void DeleteUser(int userId);
        #region User Panel
        InformationUserViewModel GetUserInformation(string userName);
        InformationUserViewModel GetUserInformation(int userId);

        SideBarUserPanelViewModel GetSideBarUserPanelData(string userName);
        EditProfileViewModel GetDataForEditProfileUser(string userName);
        void EditProfile(string userName,EditProfileViewModel profile);
        bool CompareOldPassword(string oldPassword, string userName);
        void ChangeUserPassword(string userName, string newPassword);
        #endregion
        #region Wallet
        int BalanceUserWallet(string userName);
        List<WalletViewModel> GetWalletUser(string userName);
        int ChargeWallet(string userName, int amount ,string description, bool isPay=false);
        int AddWallet(Wallet wallet);
        Wallet GetWalletByWalletId(int walletId);
        void UpdateWallet(Wallet wallet);
        #endregion
        #region Admin Panel
        UserForAdminViewModel GetUsers(int pageId = 1, string filterEmail = "", string filterUserName = "");
        UserForAdminViewModel GetDeleteUsers(int pageId = 1, string filterEmail = "", string filterUserName = "");

        int AddUserFromAdmin(CreateUserViewModel user);
        EditUserViewModel GetUserForShowInEditMode(int userId);
        void EditUserFromAdmin(EditUserViewModel editUser);
        #endregion
    }

}
