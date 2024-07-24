using System;
using System.Collections.Generic;
using System.IO.Ports;

namespace LibComm.Ports.ComPort
{
  public class ComPortUtils
  {
    static readonly Comparer comparer = new Comparer();

    class Comparer : IComparer<string>
    {
      public int Compare(string x, string y)
      {
        int xInt = -1;
        int yInt = -1;
        if (!int.TryParse(x.Substring(3), out xInt))
          return 1;
        if(!int.TryParse(y.Substring(3), out yInt))
          return -1;
        return xInt - yInt;
      }
    }

    public static string[] GetPortNames()
    {
      string[] names = SerialPort.GetPortNames();
      if ((names != null) && (names.Length > 1)) Array.Sort(names, comparer);
      return names;
    }
  }
}
