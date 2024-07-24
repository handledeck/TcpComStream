using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibComm
{
  class LibCommData : LibCommStream
  {
    public override void ReadData(Stream stream)
    {
      while (true)
      {
        Thread.Sleep(1000);
      }
    }
  }
}
