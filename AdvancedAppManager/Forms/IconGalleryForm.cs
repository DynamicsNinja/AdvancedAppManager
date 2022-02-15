using System.Collections.Generic;
using System.Windows.Forms;
using Fic.XTB.AdvancedAppManager.Model;
using Microsoft.Web.WebView2.Core;
using Microsoft.Xrm.Sdk;
using Newtonsoft.Json;

namespace Fic.XTB.AdvancedAppManager.Forms
{
    public partial class IconGalleryForm : Form
    {
        private readonly List<Entity> _images;
        private readonly AdvancedAppManager _aam;

        private string _selectedImageId = string.Empty;

        public IconGalleryForm(AdvancedAppManager aam, List<Entity> images)
        {
            _images = images;
            _aam = aam;

            InitializeComponent();
        }

        private async void IconGalleryForm_Load(object sender, System.EventArgs e)
        {
            wvIconGallery.WebMessageReceived += SetSelectedImage;
            wvIconGallery.NavigationCompleted += SendIconsToHtml;

            if (wvIconGallery?.CoreWebView2 != null) { return; }

            await wvIconGallery.EnsureCoreWebView2Async();

            var html = Properties.Resources.iconGallery;

            wvIconGallery.NavigateToString(html);
        }

        private void SendIconsToHtml(object sender, CoreWebView2NavigationCompletedEventArgs args)
        {
            var imgList = new List<IconMessage>();

            foreach (var image in _images)
            {
                var base64 = (string)image["content"];
                var webResourceType = (OptionSetValue)image["webresourcetype"];

                var mimeType = GetMimeTypeByWebresourceType(webResourceType);

                imgList.Add(new IconMessage
                {
                    id = image.Id.ToString("D"),
                    src = $"data:{mimeType};base64,{base64}"
                });
            }

            var json = JsonConvert.SerializeObject(imgList);

            wvIconGallery.CoreWebView2.PostWebMessageAsString(json);
        }

        private string GetMimeTypeByWebresourceType(OptionSetValue webResourceType)
        {
            switch (webResourceType.Value)
            {
                case 11:
                    return "image/svg+xml"; // svg
                case 5:
                    return "image/png"; // png
                default:
                    return null;
            }
        }

        private void SetSelectedImage(object sender, CoreWebView2WebMessageReceivedEventArgs args)
        {
            _selectedImageId = args.TryGetWebMessageAsString();
        }

        private void btnSelect_Click(object sender, System.EventArgs e)
        {
            _aam.SetIconById(_selectedImageId);
            Close();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
