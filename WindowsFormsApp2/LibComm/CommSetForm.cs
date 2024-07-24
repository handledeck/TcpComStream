using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using LibComm.Ports.ComPort;

using LibComm.ui;

namespace LibComm
{
  public partial class CommSetForm : Form
  {
    public static int[] Baudrates = new int[] { 110, 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 38400, 56000, 115200, 128000, 256000 };

    public static byte[] Databits = new byte[] { 5, 6, 7, 8 };
    public CommSetForm()
    {
      InitializeComponent();
      #region Заполнение списков
      iccComPort.LoadListBox += new InputComboboxControl.Loadlist(FillComPorts);
      iccParity.LoadListBox += new InputComboboxControl.Loadlist(FillParity);
      iccStopBits.LoadListBox += new InputComboboxControl.Loadlist(FillStopBits);
      iccBaudrate.LoadListBox += new InputComboboxControl.Loadlist(FillBaudrates);
      #endregion
    }

    public CommSetForm(TabConnection con): this()
    {
      IP = con.IP;
      Port = con.Port;
      tabConnection.SelectTab(con.TabActive);
      PortName = con.ComPortName;
      //Address = con.Address;
      Baudrate = con.ComPortBaudRate;
      Parity = (LibComm.Ports.ComPort.Parity)con.ComPortParity;
      StopBits = (LibComm.Ports.ComPort.StopBits)con.ComPortStopBit;
      TimeOut = con.TimeOut;
    }

    #region Функции заполнения выпадающих списков 
    private object[] FillComPorts()
    {
      object[] res = ComPortUtils.GetPortNames();
      if(res.Length == 0 || res == null)
      {
        if(MessageBox.Show("COM-порты не обнаружены. Продолжить?","Внимание",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
        {
          this.Close();
        }
        res = new object[1] { "COM1" };
      }
      return res;//ComPortUtils.GetPortNames();
    }

    private object[] FillParity()
    {
      ComboboxItem<Parity>[] items = new List<Parity>((Parity[])Enum.GetValues(typeof(Parity))).Select((p) => new ComboboxItem<Parity>(p)).ToArray();
      return items;
    }

    private object[] FillStopBits()
    {
      ComboboxItem<StopBits>[] items = new List<StopBits>((StopBits[])Enum.GetValues(typeof(StopBits))).Select((p) => new ComboboxItem<StopBits>(p)).ToArray();
      return items;
    }

    private object[] FillBaudrates()
    {
      return Baudrates.Select((i) => i.ToString()).ToArray(); 
    }
    #endregion Функции заполнения выпадающих списков 

    #region Поля формы
    public string IP
    {
      get { return txtIp.Text; }
      set { txtIp.Text = value; }
    }

    public int Port
    {
      get { return (int)nudPort.Value; }
      set { nudPort.Value = value; }
    }

    public int ConnectType
    {
      get { return tabConnection.SelectedIndex; }
    }


    //public byte Address
    //{
    //  get { return (byte)inputComboboxControl1.Value; }
    //  set { inputComboboxControl1.Value = value; }
    //}

    public string PortName
    {
      get { return iccComPort.Value.ToString(); }
      set { iccComPort.Value = value; }
    }

    public int Baudrate
    {
      get { return Int32.Parse((string)iccBaudrate.Value); }
      set { iccBaudrate.Value = value.ToString(); }
    }

    public LibComm.Ports.ComPort.Parity Parity
    {
      get { return ((ComboboxItem<Parity>)iccParity.Value).Value;}
      set { iccParity.Value = new ComboboxItem<Parity>(value);}
    }

    public LibComm.Ports.ComPort.StopBits StopBits
    {
      get { return ((ComboboxItem<StopBits>)iccStopBits.Value).Value; }
      set { iccStopBits.Value = new ComboboxItem<StopBits>(value); }
    }

    public int TimeOut
    {
      get { return (int)idcTimeOut.Value; }
      set { idcTimeOut.Value = value; }
    }
    #endregion

    private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
      TextBox txt = (TextBox)sender;
      if (string.IsNullOrWhiteSpace(txt.Text) || !IPAddress.TryParse(this.txtIp.Text,out _))
      {
        e.Cancel = true;
        txt.Focus();
        this.errorProvider1.SetError(txt, "Name should not be left blank!");
      }
      else
      {
        e.Cancel = false;
        this.errorProvider1.SetError(txt, "");
      }
    }

    private void bAccept_Click(object sender, EventArgs e)
    {
      if (ValidateChildren(ValidationConstraints.Enabled) == false)
      {
        MessageBox.Show("Проверте правильность заполнения формы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        this.DialogResult = DialogResult.None;
        return;
      }
      this.DialogResult = DialogResult.OK;
    }
    public static string GetParityString(byte parity)
    {
      if (parity == 0)
        return "Нет";
      else if (parity == 1)
      {
        return "Четный";
      }
      else
      {
        return "Нечетный";
      }

    }

    private void bCancel_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Abort;
    }

    private void idcTimeOut_ValueChanged(object sender, EventArgs e)
    {

    }
  }

  [Serializable]
  public class TabConnection {

    [DefaultValue("127.0.0.1")]
    public string IP { get; set; }
    [DefaultValue("10250")]
    public int Port { get; set; }
    public int TabActive { get; set; }
    public string ComPortName { get; set; }
    public int ComPortBaudRate { get; set; }
    public System.IO.Ports.StopBits ComPortStopBit { get; set; } = System.IO.Ports.StopBits.One;
    public System.IO.Ports.Parity ComPortParity { get; set; } = System.IO.Ports.Parity.None;
    public byte Address { get; set; }
    public int TimeOut { get; set; }

    public TabConnection()
    {
      IP = "127.0.0.1";
      Port = 10250;
      TabActive = 0;
      ComPortBaudRate = 9600;
      ComPortName = "COM1";
      ComPortParity = System.IO.Ports.Parity.None;
      ComPortStopBit = System.IO.Ports.StopBits.One;
      Address = 0;
      TimeOut = 5000;
    }

    public string GetConnectionInfo()
    {
      if (TabActive == 0)
        return $"Соединение - {ComPortName}:{ComPortBaudRate}";
      else
        return $"Соединение - {IP}:{Port}";
    }

    public bool IsTcpConnect()
    {
      return TabActive == 1;
    }

   
  }
}
