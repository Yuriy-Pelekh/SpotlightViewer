using System.Collections.ObjectModel;
using System.Threading.Tasks;
using SpotlightViewer.Services;

namespace SpotlightViewer.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<string> Images { get; set; }

        public MainViewModel(FileService fileService)
        {
            foreach (var filePath in fileService.GetFiles())
            {
                Images.Add(filePath);
            }
        }
    }
}
