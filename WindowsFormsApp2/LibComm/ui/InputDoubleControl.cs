using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace LibComm.ui
{
  /// <summary>
  /// Класс поля ввода числового значения
  /// </summary>
  partial class InputDoubleControl : UserControl
  {
    public InputDoubleControl()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Размер поля заголовка
    /// </summary>
    public int CaptionWidth
    {
      get { return Convert.ToInt32(tableLayoutPanel.ColumnStyles[0].Width); }
      set { tableLayoutPanel.ColumnStyles[0].Width = value; }
    }

    /// <summary>
    /// Название для поля
    /// </summary>
    public string Caption
    {
      get { return Title.Text; }
      set { Title.Text = value; }
    }

    /// <summary>
    /// Числовое значение
    /// </summary>
    public decimal Value
    {
      get { return nudParam.Value; }
      set { nudParam.Value = value; }
    }

    /// <summary>
    /// Максимум для значения
    /// </summary>
    public decimal Maximum
    {
      get { return nudParam.Maximum; }
      set { nudParam.Maximum = value; }
    }

    /// <summary>
    /// Минимум для значения
    /// </summary>
    public decimal Minimum
    {
      get { return nudParam.Minimum; }
      set { nudParam.Minimum = value; }
    }

    /// <summary>
    /// Задание значения шага инкремента
    /// </summary>
    public decimal Increment
    {
      get { return nudParam.Increment; }
      set { nudParam.Increment = value; }
    }

    /// <summary>
    /// Указание доступа к редактированию
    /// </summary>
    public bool ReadOnly
    {
      get { return nudParam.ReadOnly; }
      set { nudParam.ReadOnly = value; }
    }

    /// <summary>
    /// Задание кол-ва символов после запятой
    /// </summary>
    public int DecimalPlaces
    {
      get { return nudParam.DecimalPlaces; }
      set { nudParam.DecimalPlaces = value; }
    }

    /// <summary>
    /// Обработчик события по изменению значения
    /// </summary>
    public event EventHandler ValueChanged;
    private void NudParam_ValueChanged(object sender, EventArgs e)
    {
      OnValueChanged();
    }

    protected virtual void OnValueChanged()
    {
      ValueChanged?.Invoke(this, EventArgs.Empty);
    }
  }
}
