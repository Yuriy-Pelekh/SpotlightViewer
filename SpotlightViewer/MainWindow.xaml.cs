using SpotlightViewer.Services;
using SpotlightViewer.ViewModels;

namespace SpotlightViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel(new FileService());
        }
    }
}
