using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WintersAuthorSite_MVC
{
    public class Publication
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Publisher { get; set; }
        public string Snippet { get; set; }
        public string Link { get; set; }
        public string ImageName { get; set; }
        [DisplayName("Image")]
        public string ImageBase64
        {
            get
            {
                return Utils.GetImageBase64(ImageName);
            }
        }
    }
}
