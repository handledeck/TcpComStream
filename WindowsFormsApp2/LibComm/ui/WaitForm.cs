using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibComm.ui
{

  delegate System.IO.Stream GetVariantConnectionAlt();
  public delegate void ReadData(Stream stream);
  

  partial class WaitForm : Form
  {

    CancellationTokenSource __ts = null;
    CancellationToken __ct;
    public string _default = "Идет обработка данных";
    public Action Worker { get; set; }
    public event GetVariantConnectionAlt __conn;
    public ReadData __readData;
    private string _wortxt = "Идет обработка данных";
    public string WorkText { get { return _wortxt; } set { _wortxt = value; } }

    
    public WaitForm(ReadData worker, GetVariantConnectionAlt getVariantConnectionAlt)
    {
      __ts =new CancellationTokenSource();
      __ct = __ts.Token;
      // __getVariantConnectionAlt= getVariantConnectionAlt;
      InitializeComponent();
      if (worker == null)
        throw new ArgumentNullException();
      //Worker = worker;
      __readData = worker;
      __conn = getVariantConnectionAlt;
      this.Shown += WaitForm_Shown; 
    }

    private void WaitForm_Shown(object sender, EventArgs e)
    {
      if (__tsk != null)
        return;
      __tsk = Task.Factory.StartNew(new Action(() =>
      {

        Stream stream = __conn();


        if (stream == null)
        {
          this.DialogResult = DialogResult.Abort;
          //this.Close();
          //return;
        }
        else {
          __readData(stream);
          int x = 0;
        }
        
      }));
    }

    Task __tsk;

  

    protected override void OnLoad(EventArgs e)
    {
      
      base.OnLoad(e);

     
      //base.OnLoad(e);
      //})).ContinueWith(t =>
      //{

      //  //this.DialogResult = DialogResult.OK;
      //  //this.Close();
      //}, null
      ////TaskScheduler.FromCurrentSynchronizationContext()
      //); ;

    }

    public void SetPictureWait(EnumImageAction enumImageAction) {
     
        switch (enumImageAction)
        {
          case EnumImageAction.ComPort:
            this.pictureBox1.Image= imlWait.Images[15];
            break;
          case EnumImageAction.Net:
            this.pictureBox1.Image = imlWait.Images[16];
            break;
          case EnumImageAction.Reader:
            break;
          default:
            break;
        }
      this.Update();
    }

    public void SetLabelText(string text)
    {
      this.Invoke(new Action(() =>
      {
        this.label1.Text = text;
      }));
    }

    public void ChangePercent(double perc)
    {
      this.Invoke(new Action(() => {
        if (progressBar.Style == ProgressBarStyle.Marquee)
        {
          progressBar.Style = ProgressBarStyle.Blocks;
          label1.Text =  WorkText;
          //lPerc.Visibility = Visibility.Visible;
        }
        this.Text = $"Обработка данных... {perc:F0}%";
        progressBar.Value = (int)perc;
        //lPerc.Content = $"{perc:F2}%";
      }));
     
    }

    int frame = 0;
    private void timer1_Tick(object sender, EventArgs e)
    {

      this.progressBar.Value += 1;
      if (this.progressBar.Value >= 100)
        this.progressBar.Value = 0;
      pictureBox1.Image = imlWait.Images[frame];
      frame++;
      if (frame == 15)
        frame = 0;
      this.label1.Text = WorkText;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //__ct.ThrowIfCancellationRequested();
      this.DialogResult = DialogResult.Cancel;
      //__tsk.Dispose();
      //this.Close();
      
    }
  }

  public enum EnumImageAction { 
    ComPort,
    Net,
    Reader
  }
}
