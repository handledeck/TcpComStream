using LibComm.ui;

namespace LibComm
{
  partial class CommSetForm
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
      this.bCancel = new System.Windows.Forms.Button();
      this.bAccept = new System.Windows.Forms.Button();
      this.tabConnection = new System.Windows.Forms.TabControl();
      this.TabComPort = new System.Windows.Forms.TabPage();
      this.iccStopBits = new LibComm.ui.InputComboboxControl();
      this.iccComPort = new LibComm.ui.InputComboboxControl();
      this.iccParity = new LibComm.ui.InputComboboxControl();
      this.iccBaudrate = new LibComm.ui.InputComboboxControl();
      this.TabTcpIp = new System.Windows.Forms.TabPage();
      this.nudPort = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.txtIp = new System.Windows.Forms.TextBox();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.label3 = new System.Windows.Forms.Label();
      this.idcTimeOut = new LibComm.ui.InputDoubleControl();
      this.tabConnection.SuspendLayout();
      this.TabComPort.SuspendLayout();
      this.TabTcpIp.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.SuspendLayout();
      // 
      // bCancel
      // 
      this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.bCancel.Location = new System.Drawing.Point(341, 280);
      this.bCancel.Name = "bCancel";
      this.bCancel.Size = new System.Drawing.Size(78, 29);
      this.bCancel.TabIndex = 0;
      this.bCancel.Text = "Отмена";
      this.bCancel.UseVisualStyleBackColor = true;
      this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
      // 
      // bAccept
      // 
      this.bAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.bAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.bAccept.Location = new System.Drawing.Point(244, 280);
      this.bAccept.Name = "bAccept";
      this.bAccept.Size = new System.Drawing.Size(91, 29);
      this.bAccept.TabIndex = 1;
      this.bAccept.Text = "Применить";
      this.bAccept.UseVisualStyleBackColor = true;
      this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
      // 
      // tabConnection
      // 
      this.tabConnection.Controls.Add(this.TabComPort);
      this.tabConnection.Controls.Add(this.TabTcpIp);
      this.tabConnection.Location = new System.Drawing.Point(12, 12);
      this.tabConnection.Name = "tabConnection";
      this.tabConnection.SelectedIndex = 0;
      this.tabConnection.Size = new System.Drawing.Size(418, 201);
      this.tabConnection.TabIndex = 8;
      // 
      // TabComPort
      // 
      this.TabComPort.Controls.Add(this.iccStopBits);
      this.TabComPort.Controls.Add(this.iccComPort);
      this.TabComPort.Controls.Add(this.iccParity);
      this.TabComPort.Controls.Add(this.iccBaudrate);
      this.TabComPort.Location = new System.Drawing.Point(4, 24);
      this.TabComPort.Name = "TabComPort";
      this.TabComPort.Padding = new System.Windows.Forms.Padding(3);
      this.TabComPort.Size = new System.Drawing.Size(410, 173);
      this.TabComPort.TabIndex = 0;
      this.TabComPort.Text = "COM-порт";
      this.TabComPort.UseVisualStyleBackColor = true;
      // 
      // iccStopBits
      // 
      this.iccStopBits.Caption = "Количество стоповых бит:";
      this.iccStopBits.CaptionWidth = 147;
      this.iccStopBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.iccStopBits.HandChange = false;
      this.iccStopBits.Location = new System.Drawing.Point(4, 123);
      this.iccStopBits.Margin = new System.Windows.Forms.Padding(4);
      this.iccStopBits.Name = "iccStopBits";
      this.iccStopBits.Size = new System.Drawing.Size(327, 28);
      this.iccStopBits.TabIndex = 7;
      this.iccStopBits.Value = null;
      // 
      // iccComPort
      // 
      this.iccComPort.Caption = "Номер порта:";
      this.iccComPort.CaptionWidth = 147;
      this.iccComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.iccComPort.HandChange = false;
      this.iccComPort.Location = new System.Drawing.Point(6, 16);
      this.iccComPort.Margin = new System.Windows.Forms.Padding(4);
      this.iccComPort.Name = "iccComPort";
      this.iccComPort.Size = new System.Drawing.Size(325, 28);
      this.iccComPort.TabIndex = 4;
      this.iccComPort.Value = null;
      // 
      // iccParity
      // 
      this.iccParity.Caption = "Четность:";
      this.iccParity.CaptionWidth = 147;
      this.iccParity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.iccParity.HandChange = false;
      this.iccParity.Location = new System.Drawing.Point(4, 87);
      this.iccParity.Margin = new System.Windows.Forms.Padding(4);
      this.iccParity.Name = "iccParity";
      this.iccParity.Size = new System.Drawing.Size(327, 28);
      this.iccParity.TabIndex = 6;
      this.iccParity.Value = null;
      // 
      // iccBaudrate
      // 
      this.iccBaudrate.Caption = "Скорость обмена:";
      this.iccBaudrate.CaptionWidth = 147;
      this.iccBaudrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.iccBaudrate.HandChange = false;
      this.iccBaudrate.Location = new System.Drawing.Point(4, 52);
      this.iccBaudrate.Margin = new System.Windows.Forms.Padding(4);
      this.iccBaudrate.Name = "iccBaudrate";
      this.iccBaudrate.Size = new System.Drawing.Size(327, 28);
      this.iccBaudrate.TabIndex = 5;
      this.iccBaudrate.Value = null;
      // 
      // TabTcpIp
      // 
      this.TabTcpIp.Controls.Add(this.nudPort);
      this.TabTcpIp.Controls.Add(this.label2);
      this.TabTcpIp.Controls.Add(this.label1);
      this.TabTcpIp.Controls.Add(this.txtIp);
      this.TabTcpIp.Location = new System.Drawing.Point(4, 24);
      this.TabTcpIp.Name = "TabTcpIp";
      this.TabTcpIp.Padding = new System.Windows.Forms.Padding(3);
      this.TabTcpIp.Size = new System.Drawing.Size(410, 173);
      this.TabTcpIp.TabIndex = 1;
      this.TabTcpIp.Text = "TCP/IP";
      this.TabTcpIp.UseVisualStyleBackColor = true;
      // 
      // nudPort
      // 
      this.nudPort.Location = new System.Drawing.Point(112, 83);
      this.nudPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
      this.nudPort.Name = "nudPort";
      this.nudPort.Size = new System.Drawing.Size(190, 21);
      this.nudPort.TabIndex = 4;
      this.nudPort.Value = new decimal(new int[] {
            10250,
            0,
            0,
            0});
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(37, 85);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(37, 15);
      this.label2.TabIndex = 3;
      this.label2.Text = "Порт";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(37, 35);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 15);
      this.label1.TabIndex = 1;
      this.label1.Text = "IP адрес";
      // 
      // txtIp
      // 
      this.txtIp.Location = new System.Drawing.Point(112, 32);
      this.txtIp.Name = "txtIp";
      this.txtIp.Size = new System.Drawing.Size(190, 21);
      this.txtIp.TabIndex = 0;
      this.txtIp.Text = "127.0.0.1";
      this.txtIp.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // label3
      // 
      this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label3.Location = new System.Drawing.Point(6, 273);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(424, 2);
      this.label3.TabIndex = 9;
      // 
      // idcTimeOut
      // 
      this.idcTimeOut.Caption = "Время ожидания ответа (мс):";
      this.idcTimeOut.CaptionWidth = 14;
      this.idcTimeOut.DecimalPlaces = 0;
      this.idcTimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.idcTimeOut.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.idcTimeOut.Location = new System.Drawing.Point(20, 232);
      this.idcTimeOut.Margin = new System.Windows.Forms.Padding(4);
      this.idcTimeOut.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
      this.idcTimeOut.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.idcTimeOut.Name = "idcTimeOut";
      this.idcTimeOut.ReadOnly = false;
      this.idcTimeOut.Size = new System.Drawing.Size(315, 25);
      this.idcTimeOut.TabIndex = 3;
      this.idcTimeOut.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      // 
      // CommSetForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(436, 321);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.idcTimeOut);
      this.Controls.Add(this.tabConnection);
      this.Controls.Add(this.bAccept);
      this.Controls.Add(this.bCancel);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "CommSetForm";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Настройка подключения";
      this.tabConnection.ResumeLayout(false);
      this.TabComPort.ResumeLayout(false);
      this.TabTcpIp.ResumeLayout(false);
      this.TabTcpIp.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button bCancel;
    private System.Windows.Forms.Button bAccept;
    private InputDoubleControl idcTimeOut;
    private InputComboboxControl iccComPort;
    private InputComboboxControl iccBaudrate;
    private InputComboboxControl iccParity;
    private InputComboboxControl iccStopBits;
    private System.Windows.Forms.TabControl tabConnection;
    private System.Windows.Forms.TabPage TabComPort;
    private System.Windows.Forms.TabPage TabTcpIp;
    private System.Windows.Forms.ErrorProvider errorProvider1;
    private System.Windows.Forms.TextBox txtIp;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown nudPort;
    private System.Windows.Forms.Label label3;
  }
}