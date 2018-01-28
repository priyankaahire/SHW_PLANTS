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

namespace SHW_PLANTS.WindowsService
{
    
    public partial class EmailSender : ServiceBase
    {
        Timer t1;
        public EmailSender()
        {
            InitializeComponent();
            try
            {
                this.t1.Interval = 30000;
                this.t1.Enabled = false;
                this.t1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Tick);
            }
            catch(Exception ex)
            {

            }
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                t1.Enabled = true;
            }
            catch (Exception ex)
            {

            }
        }

        protected override void OnStop()
        {
        }

        private void timer1_Tick(object sender, ElapsedEventArgs e)
        {
            //Write code here to do some job depends on your requirement
            //Library.WriteErrorLog("Timer ticked and some job has been done successfully");
        }

    }
}
    