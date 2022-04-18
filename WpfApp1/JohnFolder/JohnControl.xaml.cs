using System;
using System.Windows;
using System.Windows.Controls;
namespace WpfApp1.JohnFolder
{
  /// <summary>
  /// JohnControl.xaml 的互動邏輯
  /// </summary>
  public partial class JohnControl : UserControl
  {
    private Student Student { get; set; }
    public JohnControl()
    {
      InitializeComponent();
      Student = new Student()
      {
        Name = "John",
        ChineseScore = Convert.ToInt32(ChineseValueLabel.Content),
        MathScore = Convert.ToInt32(MathValueLabel.Content),
        SciencesScore = Convert.ToInt32(SciencesValueLabel.Content),
        Socialcore = Convert.ToInt32(SocialValueLabel.Content)
      };
      NameValueLabel.Content = Student.Name;
    }

    private void Button(object sender, RoutedEventArgs e)
    {
      TotalValueLabel.Content = Student.CalculateTotalScore();
    }
  }
}
