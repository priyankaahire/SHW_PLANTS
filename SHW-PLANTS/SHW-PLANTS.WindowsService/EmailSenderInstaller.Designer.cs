namespace SHW_PLANTS.WindowsService
{
    partial class EmailSenderInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SHW_PLANTS_EmailProcess = new System.ServiceProcess.ServiceProcessInstaller();
            this.SHW_PLANTS_EmailService = new System.ServiceProcess.ServiceInstaller();
            // 
            // SHW_PLANTS_EmailProcess
            // 
            this.SHW_PLANTS_EmailProcess.Password = null;
            this.SHW_PLANTS_EmailProcess.Username = null;
            // 
            // SHW_PLANTS_EmailService
            // 
            this.SHW_PLANTS_EmailService.ServiceName = "SHW_PLANTS_EmailService";
            // 
            // EmailSenderInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.SHW_PLANTS_EmailProcess,
            this.SHW_PLANTS_EmailService});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller SHW_PLANTS_EmailProcess;
        private System.ServiceProcess.ServiceInstaller SHW_PLANTS_EmailService;
    }
}