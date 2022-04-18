using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1.user1 {
  /// <summary>
  /// User1Control.xaml 的互動邏輯
  /// </summary>
  public partial class User1Control : UserControl {
    public User1Control() {
      InitializeComponent();
    }

    private void Button(object sender, RoutedEventArgs e) {
      TotalLabel.Content = TotalLabel.Content.ToString() + Rt(ChineseLabel.Content.ToString(),
        MathLabel.Content.ToString(), SciencesLabel.Content.ToString(),
        SocialLabel.Content.ToString());
    }

    private int Rt(string chinesetext, string mathtext, string sciencestext,
      string socialtext) {
      return Convert.ToInt32(chinesetext.Substring(3)) +
        Convert.ToInt32(mathtext.Substring(3)) +
        Convert.ToInt32(sciencestext.Substring(3)) +
        Convert.ToInt32(socialtext.Substring(3));
    }
  }
}
