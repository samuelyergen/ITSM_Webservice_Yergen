using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DAL;
using BLL;

namespace PrintSystem
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "PrintSystem" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez PrintSystem.svc ou PrintSystem.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class PrintSystem : IPrintSystem
    {   
        //directly return the number of copies available
        public int AddAmount(string username, float amount)
        {
            IUserDB userDB = new UserDB();
            IUserManager userManager = new UserManager(userDB);
            var copies = userManager.UpdateAmountByUsername(username, amount);
            return copies;
            
        }

        //directly return the number of copies available
        public int TransferMoney(int id, float amount)
        {
            IUserDB userDB = new UserDB();
            IUserManager userManager = new UserManager(userDB);
            var copies = userManager.UpdateAmountById(id, amount);
            return copies;
        }

       

        
    }
}
