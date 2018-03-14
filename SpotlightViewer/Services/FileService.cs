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
            var root = Environment.ExpandEnvironmentVariables("%localappdata%");
            var r = new DirectoryInfo(root);
            r = r.Parent.Parent.Parent;
            
            const string directory = @"Packages\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\LocalState\Assets";
            
            var path = Path.Combine(r.FullName, directory);

            if (!Directory.Exists(path))
            {
                return Enumerable.Empty<string>();
            }
            var d = new DirectoryInfo(path);
            var rr = d.GetFiles();
            return rr.Select(file => file.FullName);
        }
    }
}
