using System.ComponentModel;

namespace LibComm.Ports.ComPort
{
  public enum Parity : byte
  {

    /// <summary>
    /// Контроль четности не осуществляется
    /// </summary>
    [Description("Нет")]
    None = 0,

    /// <summary>
    /// Устанавливает бит четности так, чтобы число установленных битов всегда было нечетным
    /// </summary>
    [Description("Нечетный")]
    Odd = 1,

    /// <summary>
    /// Устанавливает бит четности так, чтобы число установленных битов всегда было четным
    /// </summary>
    [Description("Четный")]
    Even = 2
  }

  /// <summary>
  /// Указывает число стоповых битов
  /// </summary>
  public enum StopBits : byte
  {

    /// <summary>
    /// Используется один стоповый бит
    /// </summary>
    [Description("1")]
    One = 1,

    /// <summary>
    /// Используются два стоповых бита
    /// </summary>
    [Description("2")]
    Two = 2,
  }

  /// <summary>
  /// Задает управление потоком
  /// </summary>
  public enum Handshake : byte
  {
    /// <summary>
    /// Без управления потоком
    /// </summary>
    [Description("Нет")]
    None = 0,

    /// <summary>
    /// Постоянно включенный RTS
    /// </summary>
    [Description("RTS всегда включен")]
    RTS_On = 1,

    /// <summary>
    /// Аппаратное
    /// </summary>
    [Description("Аппаратно")]
    Hardware = 2,

    /// <summary>
    /// Переключение RTS
    /// </summary>
    [Description("Переключение RTS")]
    RTS_Switch = 3,
  }

}
