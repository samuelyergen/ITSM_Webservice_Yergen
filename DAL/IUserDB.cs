namespace DAL
{
    public interface IUserDB
    {
        float getAmountById(int id);
        float getAmountByUsername(string username);
        void UpdateAmountByID(int id, float amount);
        void UpdateAmountByUsername(string username, float amount);
    }
}