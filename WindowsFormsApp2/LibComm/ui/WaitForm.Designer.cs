namespace LibComm.ui
{
  partial class WaitForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaitForm));
      System.Windows.Forms.Timer timer1;
      this.progressBar = new System.Windows.Forms.ProgressBar();
      this.label1 = new System.Windows.Forms.Label();
      this.imlWait = new System.Windows.Forms.ImageList(this.components);
      this.button1 = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      timer1 = new System.Windows.Forms.Timer(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // progressBar
      // 
      this.progressBar.BackColor = System.Drawing.SystemColors.InactiveBorder;
      this.progressBar.ForeColor = System.Drawing.Color.DarkKhaki;
      this.progressBar.Location = new System.Drawing.Point(61, 34);
      this.progressBar.MarqueeAnimationSpeed = 50;
      this.progressBar.Name = "progressBar";
      this.progressBar.Size = new System.Drawing.Size(399, 32);
      this.progressBar.Step = 1;
      this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
      this.progressBar.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.SystemColors.Control;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
      this.label1.Location = new System.Drawing.Point(70, 5);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(399, 26);
      this.label1.TabIndex = 2;
      this.label1.Text = "Обмен данными с устройством";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // imlWait
      // 
      this.imlWait.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlWait.ImageStream")));
      this.imlWait.TransparentColor = System.Drawing.Color.Magenta;
      this.imlWait.Images.SetKeyName(0, "Frame00.png");
      this.imlWait.Images.SetKeyName(1, "Frame01.png");
      this.imlWait.Images.SetKeyName(2, "Frame02.png");
      this.imlWait.Images.SetKeyName(3, "Frame03.png");
      this.imlWait.Images.SetKeyName(4, "Frame04.png");
      this.imlWait.Images.SetKeyName(5, "Frame05.png");
      this.imlWait.Images.SetKeyName(6, "Frame06.png");
      this.imlWait.Images.SetKeyName(7, "Frame07.png");
      this.imlWait.Images.SetKeyName(8, "Frame08.png");
      this.imlWait.Images.SetKeyName(9, "Frame09.png");
      this.imlWait.Images.SetKeyName(10, "Frame10.png");
      this.imlWait.Images.SetKeyName(11, "Frame11.png");
      this.imlWait.Images.SetKeyName(12, "Frame12.png");
      this.imlWait.Images.SetKeyName(13, "Frame13.png");
      this.imlWait.Images.SetKeyName(14, "Frame14.png");
      this.imlWait.Images.SetKeyName(15, "connect.png");
      this.imlWait.Images.SetKeyName(16, "dns.png");
      // 
      // timer1
      // 
      timer1.Enabled = true;
      timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // button1
      // 
      this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.button1.Location = new System.Drawing.Point(187, 80);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(108, 25);
      this.button1.TabIndex = 4;
      this.button1.Text = "Отмена";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Location = new System.Drawing.Point(23, 34);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(32, 32);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBox1.TabIndex = 3;
      this.pictureBox1.TabStop = false;
      // 
      // WaitForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(481, 117);
      this.ControlBox = false;
      this.Controls.Add(this.button1);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.progressBar);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "WaitForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Подождите...";
      this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.ProgressBar progressBar;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.ImageList imlWait;
    private System.Windows.Forms.Button button1;
  }
}