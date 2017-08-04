using Android.App;
using Android.Widget;
using Android.OS;

namespace FFTafelvoetbal
{
    [Activity(Label = "FFTafelvoetbal", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
            SetContentView (Resource.Layout.Main);

            var tab = ActionBar.NewTab();
            tab.SetText("Players");
            tab.TabSelected += (sender, args) =>
            {
                // Do something when tab is selected
            };
            ActionBar.AddTab(tab);

            tab = ActionBar.NewTab();
            tab.SetText("Add Player");
            tab.TabSelected += (sender, args) =>
            {
                // Do something when tab is selected
            };
            ActionBar.AddTab(tab);
        }
    }
}

