using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace elemendidDovzenokD
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Webview : ContentPage
    {
        WebView webView;
        Entry urlEntry;
        public Webview()
        {
            urlEntry = new Entry { HorizontalOptions = LayoutOptions.FillAndExpand };
            Button button = new Button { Text = "Go" };
            button.Clicked += Button_Clicked; ;
            StackLayout stack = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { button, urlEntry }
            };
            webView = new WebView
            {
                Source = new UrlWebViewSource { Url = "https://dovzenok19.thkit.ee/" },

                VerticalOptions = LayoutOptions.FillAndExpand
            };

            this.Content = new StackLayout { Children = { stack, webView } };
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            webView.Source = new UrlWebViewSource { Url = urlEntry.Text };
        }
    }
}