using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFRecursos.App_Code;

namespace XFRecursos.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : MasterDetailPage
	{
		public MainPage ()
		{
			InitializeComponent ();

            menuPage.ListaMenu.ItemSelected += ListaMenu_ItemSelected;

        }

        private void ListaMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as OpcoesMenu;
            if(item != null)
            {
                Detail = new NavigationPage(
                    ((Page)Activator.CreateInstance(item.TargetType)));
                menuPage.ListaMenu.SelectedItem = null;
                this.IsPresented = false;
            }
        }
    }
}