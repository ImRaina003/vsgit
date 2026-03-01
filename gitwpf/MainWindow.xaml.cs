using System.Windows;

namespace gitwpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
          MessageBox.Show("one mroe  branch");
            MessageBox.Show("changes done by raghav raina");

        }
    }
}