using LibComm.ui;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibComm
{
  public class LibCommStream
  {
    TabConnection __tabConnection = null;
    TcpClient __tcpClient = null;
    SerialPort __serialPort = null;
    ReadData __readData = null;
    System.IO.Stream __stream = null;
    public LibCommStream(ReadData readData)
    {
      __readData = readData;
      ReadSettings();
    }

    internal void WriteSettings()
    {
      string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
      string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
      string wpth = strWorkPath + "\\connset.dat";

      BinaryFormatter formatter = new BinaryFormatter();
      using (FileStream fs = new FileStream(wpth, FileMode.OpenOrCreate))
      {
        formatter.Serialize(fs, __tabConnection);
      }
    }

    internal void ReadSettings()
    {
      string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
      string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);

      BinaryFormatter formatter = new BinaryFormatter();
      string wpth = strWorkPath + "\\connset.dat";
      using (FileStream fs = new FileStream(wpth, FileMode.OpenOrCreate))
      {
        try
        {
          __tabConnection = (TabConnection)formatter.Deserialize(fs);
        }
        catch (Exception)
        {
          __tabConnection = new TabConnection();
          formatter.Serialize(fs, __tabConnection);
        }
      }
    }

    public void ShowConnectionForm() {
      ReadSettings();
      using (CommSetForm frm = new CommSetForm(__tabConnection))
      {
        if (frm.ShowDialog() == DialogResult.OK)
        {
          __tabConnection.IP = frm.IP;
          __tabConnection.Port = frm.Port;
          __tabConnection.TabActive = frm.ConnectType;
          //__tabConnection.Address = frm.Address;
          __tabConnection.ComPortName = frm.PortName;
          __tabConnection.ComPortBaudRate = frm.Baudrate;
          __tabConnection.ComPortParity = (System.IO.Ports.Parity)frm.Parity;
          __tabConnection.ComPortStopBit = (System.IO.Ports.StopBits)frm.StopBits;
          __tabConnection.TimeOut = frm.TimeOut;
          WriteSettings();
        };
      }
    }

   

    System.IO.Stream GetVariantConnectionAlt()
    {
      try
      {
        if (__tabConnection.IsTcpConnect())
        {
          __stream = GetTcpConnection(__tabConnection.IP, __tabConnection.Port, __tabConnection.TimeOut);
        }
        else
        {
          __stream = GetUartConnection(__tabConnection.ComPortName, __tabConnection.ComPortBaudRate,
              __tabConnection.ComPortParity, __tabConnection.ComPortStopBit);
        }
        if (__stream != null)
          __stream.ReadTimeout = __tabConnection.TimeOut;

        return __stream;
      }
      catch
      {
        return null;
      }
    }

    Stream GetTcpConnection(string host, int port, int timeout)
    {
      //Stream stream = null;
      __tcpClient = new TcpClient();
      IAsyncResult result = __tcpClient.BeginConnect(host, port, (i) => {
        __tcpClient = (TcpClient)i.AsyncState;
        
      }, __tcpClient);
      bool state = result.AsyncWaitHandle.WaitOne(timeout);
      if (__tcpClient == null)
        return null;
      if (!__tcpClient.Connected)
        return null;
      else
      {
        //__tcpClient.ReceiveTimeout = __tabConnection.TimeOut;
        __stream = __tcpClient.GetStream();
        __stream.ReadTimeout = __tabConnection.TimeOut;
        return __stream;
      }
    }

    Stream GetUartConnection(string comPort, int boudRate, Parity parity, StopBits stopBits)
    {
      Stream stream = null;
      try
      {
        __serialPort = new System.IO.Ports.SerialPort(comPort, boudRate, parity, 8, stopBits); 
      }
      catch
      {
        return null;
      }
      __serialPort.Open();
      stream = __serialPort.BaseStream;
      stream.ReadTimeout = __tabConnection.TimeOut;
      return stream;
    }



    public void Open() {
      using (WaitForm frm = new WaitForm(__readData, GetVariantConnectionAlt))
      {
        try
        {

        
        frm.WorkText = "Открытие канала связи";
        if (__tabConnection.IsTcpConnect())
        {
          frm.SetPictureWait(EnumImageAction.Net);
        }
        else
        {
          frm.SetPictureWait(EnumImageAction.ComPort);
        }

        DialogResult res = frm.ShowDialog();

        if (res == DialogResult.Abort)
        {
          MessageBox.Show("Таймаут открытия канала","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
          frm.Close();
        }
        else if (res== DialogResult.Cancel) {
            //if(__stream!=null)
            //__stream.Dispose();
            //  __stream = null;


            if (__tcpClient != null)
              __tcpClient.Client.Dispose();
            if (__serialPort != null)
              __serialPort.Dispose();
            __serialPort = null;
            __tcpClient = null;
            //frm.Close();
            //MessageBox.Show("Отмена", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          }
        }
        catch (Exception)
        {

          throw;
        }
      }
    }
  } 
}
