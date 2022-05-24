using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementApplication
{
    public sealed class Singleton
    {

        private static Singleton instance= null;
        private static readonly object padlock = new object();
        public ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        Singleton()
        {

        }

        public static Singleton Instance
        {
            get 
            { 
            lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }

        public void messagePrint( string message)
        {
            MessageBox.Show(message);
        }

        public void printLoggInfo( string message)
        {
            FileStream fs = new FileStream("../../log4netConfig.xml", FileMode.Open);
            XmlConfigurator.Configure(fs);
            logger.Info(message);
            fs.Close();
        }

        public void printLoggError(string message)
        {
            FileStream fs = new FileStream("../../log4netConfig.xml", FileMode.Open);
            XmlConfigurator.Configure(fs);
            logger.Error(message);
            fs.Close();
        }
    };
}
