using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaludGestREST.Services.Settings
{
    public class UploadSettings
    {
        public string UploadDirectory { get; set; }
        public string AllowedExtensions { get; set; }
        public int MaxFileSizeInMb { get; set; }
    }
}
