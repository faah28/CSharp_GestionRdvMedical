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

                WriteLogSystem("Démarrage du service", $"Service démarré à {DateTime.Now}");

                aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);

                aTimer.Interval = 1000;
                aTimer.AutoReset = false;
                aTimer.Enabled = true;
            }
            private static void OnTimedEvent(Object source, ElapsedEventArgs e)
            {
                try
                {
                    WriteLogSystem("test", DateTime.Now.ToString());
                }
                catch (Exception ex)
                {

                }
                //Thread.Sleep(300000);
                aTimer.Start();
            }

            protected override void OnStop()
            {
                aTimer.Stop();
                aTimer.Dispose();
                WriteLogSystem("Arret du service SenMail", string.Format("Le service est arrété à {0}", DateTime.Now));
            }

            private static void WriteLogSystem(string erreur, string libelle)
            {
                string source = "ServiceL3GlG2";

                // Vérifier si la source existe, sinon la créer
                if (!EventLog.SourceExists(source))
                {
                    EventLog.CreateEventSource(source, "Application");
                }

                using (EventLog eventLog = new EventLog("Application"))
                {
                    eventLog.Source = source;
                    eventLog.WriteEntry($"Erreur : {erreur} | Détail : {libelle}", EventLogEntryType.Information);
                }
            }


        }
    }
