using System;
using System.Windows;
using System.Windows.Controls;
namespace WpfApp1.MaryFolder
{
  /// <summary>
  /// MaryControl.xaml 的互動邏輯
  /// </summary>
  public partial class MaryControl : UserControl
  {
    private Student Student { get; set; }
    public MaryControl()
    {
      InitializeComponent();
      Student = MainWindow.Mary;
      DataContext = Student;
    }
      private void Button(object sender, RoutedEventArgs e)
      {
        TotalValueLabel.Content = Student.CalculateTotalScore();
      }
    }
}
