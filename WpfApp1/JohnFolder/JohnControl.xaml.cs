using System;
using System.Windows;
using System.Windows.Controls;
using WpfApp1;
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
      Student = MainWindow.John;
      DataContext = Student;
    }

    private void Button(object sender, RoutedEventArgs e)
    {
      TotalValueLabel.Content = Student.CalculateTotalScore();
    }
  }
}
