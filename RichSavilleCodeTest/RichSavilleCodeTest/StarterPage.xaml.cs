using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RichSavilleCodeTest
{
    public partial class StarterPage : ContentPage
    {
        StarterPageViewModel viewModel;
        public StarterPage()
        {
            InitializeComponent();

            viewModel = new StarterPageViewModel();
            BindingContext = viewModel;

            UpdateList.Clicked += UpdateListView;
        }

        private async void UpdateListView(object sender, EventArgs e)
        {
            var remoteClient = new ListJson();
            viewModel.Movielist = await remoteClient.GetRootObject().ConfigureAwait(false);
        }

    }
}
