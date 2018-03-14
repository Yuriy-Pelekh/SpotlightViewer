using SpotlightViewer.Services;
using SpotlightViewer.ViewModels;

namespace SpotlightViewer
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            DataContext = new MainViewModel(new FileService());
        }
    }
}
