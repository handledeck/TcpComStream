
namespace LibComm
{
  partial class Form1
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
      this.inputComboboxControl1 = new LibComm.ui.InputComboboxControl();
      this.inputDoubleControl1 = new LibComm.ui.InputDoubleControl();
      this.SuspendLayout();
      // 
      // inputComboboxControl1
      // 
      this.inputComboboxControl1.Caption = "label1";
      this.inputComboboxControl1.CaptionWidth = 175;
      this.inputComboboxControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.inputComboboxControl1.HandChange = true;
      this.inputComboboxControl1.Location = new System.Drawing.Point(78, 33);
      this.inputComboboxControl1.Margin = new System.Windows.Forms.Padding(4);
      this.inputComboboxControl1.Name = "inputComboboxControl1";
      this.inputComboboxControl1.Size = new System.Drawing.Size(443, 28);
      this.inputComboboxControl1.TabIndex = 0;
      this.inputComboboxControl1.Value = null;
      // 
      // inputDoubleControl1
      // 
      this.inputDoubleControl1.Caption = "Cthbqysq yjvth";
      this.inputDoubleControl1.CaptionWidth = 80;
      this.inputDoubleControl1.DecimalPlaces = 6;
      this.inputDoubleControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.inputDoubleControl1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.inputDoubleControl1.Location = new System.Drawing.Point(118, 105);
      this.inputDoubleControl1.Margin = new System.Windows.Forms.Padding(4);
      this.inputDoubleControl1.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
      this.inputDoubleControl1.Minimum = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.inputDoubleControl1.Name = "inputDoubleControl1";
      this.inputDoubleControl1.ReadOnly = false;
      this.inputDoubleControl1.Size = new System.Drawing.Size(350, 35);
      this.inputDoubleControl1.TabIndex = 1;
      this.inputDoubleControl1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.inputDoubleControl1);
      this.Controls.Add(this.inputComboboxControl1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private ui.InputComboboxControl inputComboboxControl1;
    private ui.InputDoubleControl inputDoubleControl1;
  }
}