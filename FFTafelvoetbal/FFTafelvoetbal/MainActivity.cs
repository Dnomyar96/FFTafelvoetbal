using Android.App;
using Android.Widget;
using Android.OS;
using FFTafelvoetbal.Fragments;
using Android.Graphics.Drawables;

namespace FFTafelvoetbal
{
    [Activity(Label = "Secret Project", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
            SetContentView (Resource.Layout.Main);

            Alert.AddContext(this);

            var tab = ActionBar.NewTab();
            tab.SetText("Players");
            tab.TabSelected += (sender, e) =>
            {
                e.FragmentTransaction.Replace(Resource.Id.fragmentContainer, new PlayerListFragment());
            };
            ActionBar.AddTab(tab);

            tab = ActionBar.NewTab();
            tab.SetText("Add Player");
            tab.TabSelected += (sender, e) =>
            {
                e.FragmentTransaction.Replace(Resource.Id.fragmentContainer, new AddPlayerFragment());
            };
            ActionBar.AddTab(tab);
        }
    }
}

