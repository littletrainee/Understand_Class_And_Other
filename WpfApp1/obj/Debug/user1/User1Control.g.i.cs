// Updated by XamlIntelliSenseFileGenerator 2022/4/18 下午 07:23:10
#pragma checksum "..\..\..\user1\User1Control.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1BD73327A1FB8BE5065FF3C771B7083219FEBECFA7516B3E4AD30F4F6B5EC010"
//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace WpfApp1.user1
{


  /// <summary>
  /// User1Control
  /// </summary>
  public partial class User1Control : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
  {

#line default
#line hidden

    private bool _contentLoaded;

    /// <summary>
    /// InitializeComponent
    /// </summary>
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
      if (_contentLoaded)
      {
        return;
      }
      _contentLoaded = true;
      System.Uri resourceLocater = new System.Uri("/WpfApp1;component/user1/user1control.xaml", System.UriKind.Relative);

#line 1 "..\..\..\user1\User1Control.xaml"
      System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
    }

    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
    void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
    {
      switch (connectionId)
      {
        case 1:
          this.NameLabel = ((System.Windows.Controls.Label)(target));
          return;
        case 2:
          this.NameValueLabel = ((System.Windows.Controls.Label)(target));
          return;
        case 3:
          this.ChineseLabel = ((System.Windows.Controls.Label)(target));
          return;
        case 4:
          this.ChineseValueLabel = ((System.Windows.Controls.Label)(target));
          return;
        case 5:
          this.MathLabel = ((System.Windows.Controls.Label)(target));
          return;
        case 6:
          this.MathValueLabel = ((System.Windows.Controls.Label)(target));
          return;
        case 7:
          this.SciencesLabel = ((System.Windows.Controls.Label)(target));
          return;
        case 8:
          this.SciencesValueLabel = ((System.Windows.Controls.Label)(target));
          return;
        case 9:
          this.SocialLabel = ((System.Windows.Controls.Label)(target));
          return;
        case 10:
          this.SocialValueLabel = ((System.Windows.Controls.Label)(target));
          return;
        case 11:
          this.TotalLabel = ((System.Windows.Controls.Label)(target));
          return;
        case 12:
          this.TotalValueLabel = ((System.Windows.Controls.Label)(target));
          return;
        case 13:
          this.CalculateButton = ((System.Windows.Controls.Button)(target));

#line 100 "..\..\..\user1\User1Control.xaml"
          this.CalculateButton.Click += new System.Windows.RoutedEventHandler(this.Button);

#line default
#line hidden
          return;
      }
      this._contentLoaded = true;
    }
  }
}

