using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class UserManager : IUserManager
    {
        private IUserDB UserDB { get; }

        public UserManager(IUserDB userDB)
        {
            UserDB = userDB;
        }

        public int ConvertToCopies(float amount)
        {
            var copies = Math.Floor(amount / 0.08);

            return (int)copies;

        }

        public float getAmountById(int id)
        {
            var amount = UserDB.getAmountById(id);
            return amount;
        }

        public float getAmountByUsername(string username)
        {
            var amount = UserDB.getAmountByUsername(username);
            return amount;
        }


        public int UpdateAmountByUsername(string username, float amount)
        {
            var currentAmount = UserDB.getAmountByUsername(username);
            var totalAmount = currentAmount + amount;
            UserDB.UpdateAmountByUsername(username, totalAmount);
            var copies = ConvertToCopies(totalAmount);
            return copies;
        }

        public int UpdateAmountById(int id, float amount)
        {
            var currentAmount = UserDB.getAmountById(id);
            var totalAmount = currentAmount + amount;
            UserDB.UpdateAmountByID(id, totalAmount);
            var copies = ConvertToCopies(totalAmount);
            return copies;
        }
    }
}
