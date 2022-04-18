using System;
using System.Windows;
using System.Windows.Controls;
namespace WpfApp1.user2
{
  /// <summary>
  /// User2.xaml 的互動邏輯
  /// </summary>
  public partial class User2 : UserControl
  {
    public User2()
    {
      InitializeComponent();
    }


    private void Button(object sender, RoutedEventArgs e)
    {
      TotalLabel.Content = TotalLabel.Content.ToString() + Rt(ChineseLabel.Content.ToString(),
        MathLabel.Content.ToString(), SciencesLabel.Content.ToString(),
        SocialLabel.Content.ToString());
    }

    private int Rt(string chinesetext, string mathtext, string sciencestext,
      string socialtext)
    {
      return Convert.ToInt32(chinesetext.Substring(3)) +
        Convert.ToInt32(mathtext.Substring(3)) +
        Convert.ToInt32(sciencestext.Substring(3)) +
        Convert.ToInt32(socialtext.Substring(3));
    }
  }
}
