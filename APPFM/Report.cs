
namespace APPFM
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Report_Load); // Đúng

            
        }


        private void Report_Load(object sender, EventArgs e)
        {
            try
            {
                // Tạo ReportViewer
             
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }



    }
}
