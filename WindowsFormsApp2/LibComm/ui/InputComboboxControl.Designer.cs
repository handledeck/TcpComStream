
namespace LibComm.ui
{
  partial class InputComboboxControl
  {
    /// <summary> 
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором компонентов

    /// <summary> 
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.Title = new System.Windows.Forms.Label();
      this.cbList = new System.Windows.Forms.ComboBox();
      this.tableLayoutPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel
      // 
      this.tableLayoutPanel.ColumnCount = 2;
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel.Controls.Add(this.Title, 0, 0);
      this.tableLayoutPanel.Controls.Add(this.cbList, 1, 0);
      this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
      this.tableLayoutPanel.Name = "tableLayoutPanel";
      this.tableLayoutPanel.RowCount = 1;
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
      this.tableLayoutPanel.Size = new System.Drawing.Size(443, 28);
      this.tableLayoutPanel.TabIndex = 0;
      // 
      // Title
      // 
      this.Title.AutoSize = true;
      this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Title.Location = new System.Drawing.Point(4, 0);
      this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.Title.Name = "Title";
      this.Title.Size = new System.Drawing.Size(167, 28);
      this.Title.TabIndex = 0;
      this.Title.Text = "label1";
      this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // cbList
      // 
      this.cbList.Dock = System.Windows.Forms.DockStyle.Top;
      this.cbList.FormattingEnabled = true;
      this.cbList.Location = new System.Drawing.Point(178, 3);
      this.cbList.Name = "cbList";
      this.cbList.Size = new System.Drawing.Size(262, 23);
      this.cbList.TabIndex = 1;
      this.cbList.SelectedIndexChanged += new System.EventHandler(this.cbList_SelectedIndexChanged);
      // 
      // InputComboboxControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "InputComboboxControl";
      this.Size = new System.Drawing.Size(443, 28);
      this.Load += new System.EventHandler(this.InputComboboxControl_Load);
      this.tableLayoutPanel.ResumeLayout(false);
      this.tableLayoutPanel.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    private System.Windows.Forms.Label Title;
    private System.Windows.Forms.ComboBox cbList;
  }
}
