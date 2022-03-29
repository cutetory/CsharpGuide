using System.Data.OleDb;
using System.Windows.Forms;
using System.Text;
using System.Drawing;
using System.Data;
using System.Data.Common;

namespace WinFormsApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private static string connectionInfo = "Provider=OraOLEDB.Oracle;Data Source=XE;User ID=juny;Password=oracle;Unicode=True";
		private string selectDb = "SELECT * FROM dept";
		OleDbConnection conn = new OleDbConnection(connectionInfo);

		private void button1_Click(object sender, EventArgs e)
		{
			conn.Open();
			OleDbDataAdapter adapter = new OleDbDataAdapter(selectDb,conn);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;
			conn.Close();
		}
	}
}