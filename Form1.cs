using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementApplication;
using log4net;
using log4net.Config;

namespace HotelManagementApplicationlication
{
    public partial class Form1 : Form
    {
        Staff_tbl model = new Staff_tbl();
        FileStream fs = new FileStream("../../log4netConfig.xml", FileMode.Open);
        private protected ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public Form1()
        {
            InitializeComponent();
            XmlConfigurator.Configure(fs);
        }

        private void button1_Click(object sender, EventArgs e)
        {
                StaffServices staffServices= new StaffServices();
                var dataset = staffServices.validate(usernametb.Text, passwordtb.Text);
                if (dataset != null)
                {
                    
                    Main mf = new Main();
                    mf.Show();
                    this.Hide();
                    logger.Info("Staff logged "+ usernametb.Text);
                }
                else {
                    //Singletone
                    Singleton s = Singleton.Instance;
                    s.messagePrint("Wrong Username or Password!");
                    logger.Warn("Wrong Password or Username ");
            }


        }
    }
}
