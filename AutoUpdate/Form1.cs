using System.Reflection;

namespace AutoUpdate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Form Loaded");
            var appVersion = Assembly.GetExecutingAssembly().GetName().Version;

            lblVersion.Text = $"Version: {appVersion.Major}.{appVersion.Minor}.{appVersion.Build}";
        }
    }
}
