using Microsoft.UI.Xaml;

namespace Micalangelo
{
  /// <summary>
  ///   An empty window that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class MainWindow
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void myButton_Click(object sender, RoutedEventArgs e)
    {
      MyButton.Content = "Clicked";
    }
  }
}
