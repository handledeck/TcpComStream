using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  public partial class Form1 : Form
  {
    LibComm.CommSetForm commSetForm;
    public Form1()
    {
      InitializeComponent();
      commSetForm = new LibComm.CommSetForm(new LibComm.TabConnection());
      
    }

    private void button1_Click(object sender, EventArgs e)
    {
      LibComm.LibCommStream libCommStr = new LibComm.LibCommStream(null);
      byte[] data = new byte[1024];
      LibComm.LibCommStream libCommStream = new LibComm.LibCommStream(new LibComm.ui.ReadData(d => {
        try {
          d.Read(data, 0, data.Length);
        }
        catch (Exception exp)
   {

          throw;
        }

      }));
      libCommStream.ShowConnectionForm();

      libCommStream.Open();
    }
  }
}
