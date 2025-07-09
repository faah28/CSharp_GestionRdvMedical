using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ServiceSendMail
{
    public partial class ServiceL3GLG2 : ServiceBase
    {
        private static Timer aTimer;
        public ServiceL3GLG2()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            aTimer = new System.Timers.Timer(1000);
            WriteLogSystem("Démarrage du service SenMail", string.Format("Le service est démaré à {0}", DateTime.Now));

            aTimer.Elapsed += new ElapsedEventHandler(OnTimeEvent);

            aTimer.Interval = 1000;
            aTimer.AutoReset = false;
            aTimer.Enabled = true;
        }

        private static void OnTimeEvent(object source, ElapsedEventArgs e)
        {
            try
            {
                WriteLogSystem("test", DateTime.Now.ToString());
            }
            catch(Exception ex) 
            {
                
            }
            //Tread.Sleep(300000)
            aTimer.Start();

        }
        protected override void OnStop()
        {
            aTimer.Stop();
            aTimer.Dispose();
            WriteLogSystem("Arret du service SenMail", string.Format("Le service est arrété à {0}",DateTime.Now));
        }

        public static void WriteLogSystem(string erreur ,string libelle)
        {
            using (EventLog eventLog = new EventLog("Application"))
            {
                eventLog.Source = "Send Mail: ";
                eventLog.WriteEntry(string.Format("date: {0} ,libelle: {1} ,description {2}", DateTime.Now, libelle));
            }
        }
    }
}
