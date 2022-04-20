using System.Windows;
namespace WpfApp1 {
  /// <summary>
  /// MainWindow.xaml 的互動邏輯
  /// </summary>
  public partial class MainWindow : Window {

    // declare variable to instance Student Class and setting property
    public static Student John { get; set; } = new Student() {
      Name = "John",
      ChineseScore = 100,
      MathScore = 90,
      SciencesScore = 80,
      SocialScore = 70
    };

    public static Student Mary { get; set; } = new Student() {
      Name = "Mary",
      ChineseScore = 99,
      MathScore = 98,
      SciencesScore = 97,
      SocialScore = 96
    };

    // program start
    public MainWindow() {
      InitializeComponent();
      // instance class from here
      JohnUserControl.Student = John;
      MaryUserControl.Student = Mary;
    }
  }
}
