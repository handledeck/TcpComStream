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
  partial class InputComboboxControl : UserControl
  {
    public delegate void ChangeCbIndex(int index); 

    public InputComboboxControl()
    {
      InitializeComponent();
    }

    #region Параметры управления панелью
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
    /// Доступ ручного ввода
    /// </summary>
    public bool HandChange
    {
      get { return (cbList.DropDownStyle == ComboBoxStyle.DropDown); }
      set { cbList.DropDownStyle = (value) ? ComboBoxStyle.DropDown : ComboBoxStyle.DropDownList; }
    }
    
    /// <summary>
    /// Текущее значения из списка
    /// </summary>
    private object _value = null;
    public object Value
    {
      get { return _value; }
      set { _value = value; }
    }

    public int SelectIndex
    {
      get { return cbList.SelectedIndex; }
    }
    #endregion //Параметры управления панелью

    /// <summary>
    /// Делегат для внешнего загрузчика списка
    /// </summary>
    /// <returns></returns>
    public delegate object[] Loadlist();
    public event Loadlist LoadListBox;
    public event ChangeCbIndex ChangeIndex;

    /// <summary>
    /// Генерация списка через внешний делегат и задание текущего значения
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void InputComboboxControl_Load(object sender, EventArgs e)
    {
      if (LoadListBox != null)
      {
        cbList.Items.AddRange(LoadListBox?.Invoke());
        if (_value != null && cbList.Items.Contains(_value))
        {
          cbList.SelectedItem = _value;
        }
        else
          cbList.SelectedIndex = 0;
      }
    }

    private void cbList_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (ChangeIndex != null)
        ChangeIndex(cbList.SelectedIndex);
      Value = cbList.SelectedItem;
    }
  }
}
