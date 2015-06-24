using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Imgur.API;
using Imgur.API.EndPoints;
using Imgur.API.EndPoints.Gallery;
using Imgur.API.Model.Enum;
using System.Net.Http;
using Imgur.API.Model.Entities;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Imgur.SampleApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            ApiRoot.Instance.Init("XXXXXXXX", "XXXXXX");
           


            var result = await ApiRoot.Instance.GetEndPointEntityAsync<RootElement<GalleryImage>>(
                new Gallery()
                {
                    page = 0,
                    section = Section.hot.ToString(),
                    showViral = true,
                    sort = Sort.top.ToString(),
                    window = Imgur.API.Model.Enum.Windows.day.ToString(),
                });
        }
    }
}
