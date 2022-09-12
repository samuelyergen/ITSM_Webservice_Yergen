using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrinterForm
{
    public partial class Form1 : Form
    {
        
        ServicePrint.PrintSystemClient client;

        public Form1()
        {
            InitializeComponent();

            
            client = new ServicePrint.PrintSystemClient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                
                var money = amount.Text;
                var username = name.Text;
                            
                var co = client.AddAmount(username, float.Parse(money.ToString()));
                             
                copies.Text = co.ToString();
                       
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var money = amountid.Text;
            var id = iduser.Text;
           
            var co = client.TransferMoney(int.Parse(id), float.Parse(money));

            copiesid.Text = co.ToString();
        }
    }
}
