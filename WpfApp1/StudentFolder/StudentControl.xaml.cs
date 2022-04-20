using System.Windows;
using System.Windows.Controls;
namespace WpfApp1.StudentFolder {
  /// <summary>
  /// JohnControl.xaml 的互動邏輯
  /// </summary>
  public partial class StudentControl : UserControl {
    // declare variable
    public Student Student { get; set; }
    // class inititalize 
    public StudentControl() {
      InitializeComponent();
    }

    // declare button method
    private void Button(object sender, RoutedEventArgs e) {
      TotalValueLabel.Content = Student.CalculateTotalScore();
    }

    // delcare UserControl's Loaded method
    private void UserControl_Loaded(object sender, RoutedEventArgs e) {
      NameValueLabel.Content = Student.Name;
      ChineseValueLabel.Content = Student.ChineseScore;
      MathValueLabel.Content = Student.MathScore;
      SciencesValueLabel.Content = Student.SciencesScore;
      SocialValueLabel.Content = Student.SocialScore;
    }
  }
}
