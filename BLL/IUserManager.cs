namespace BLL
{
    public interface IUserManager
    {
        int ConvertToCopies(float amount);
        float getAmountById(int id);
        float getAmountByUsername(string username);
        int UpdateAmountById(int id, float amount);
        int UpdateAmountByUsername(string username, float amount);
    }
}