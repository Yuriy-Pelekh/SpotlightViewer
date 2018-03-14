using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SpotlightViewer.Services
{
    public class FileService
    {
        public IEnumerable<string> GetFiles()
        {
            var root = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            const string directory = @"Packages\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\LocalState\Assets";
            var path = Path.Combine(root, directory);
            if (!Directory.Exists(path))
            {
                return Enumerable.Empty<string>();
            }

            var assets = new DirectoryInfo(path);
            var files = assets.GetFiles();
            return files.Select(file => file.FullName);
        }
    }
}
