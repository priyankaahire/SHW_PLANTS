using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace SHW_PLANTS.WindowsService
{
    [RunInstaller(true)]
    public partial class EmailSenderInstaller : System.Configuration.Install.Installer
    {
        public EmailSenderInstaller()
        {
            InitializeComponent();
        }
    }
}
