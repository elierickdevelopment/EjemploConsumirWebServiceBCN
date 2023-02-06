using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploConsumirWebServiceBCN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ws_BCN.Tipo_Cambio_BCNSoapClient ws = new ws_BCN.Tipo_Cambio_BCNSoapClient();
            DataSet ds = new DataSet();
            ds.ReadXml(new StringReader(ws.RecuperaTC_Mes(2023, 1).ToString()));
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Refresh();
        }
    }
}
