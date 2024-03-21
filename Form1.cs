using log4net;
using log4net.Config;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        // Define a static logger variable so that it references the
        // Logger instance named "Form1".
        //private static readonly ILog log = LogManager.GetLogger("Program");
        private static readonly ILog log = LogManager.GetLogger(typeof(Form1));
        public Form1()
        {
            InitializeComponent();
            // Set up a simple configuration that logs on the console.
            //BasicConfigurator.Configure();
            XmlConfigurator.Configure(new FileInfo("log4net.config"));
            log.Info("Entering application.");
            Console.WriteLine("this is console.writeline1");
            log.Error("Exiting application.");
            log.Debug("this is debug");
            log.Warn("this is warn", new Exception("发生了一个警告"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();  
            form2.ShowDialog();
        }
    }
}
