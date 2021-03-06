using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace FFTafelvoetbal.Fragments
{
    public class AddPlayerFragment : Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            base.OnCreateView(inflater, container, savedInstanceState);

            var view = inflater.Inflate(Resource.Layout.AddPlayerTab, container, false);

            view.FindViewById<Button>(Resource.Id.addPlayerButton).Click += (sender, e) =>
            {
                var player = view.FindViewById<EditText>(Resource.Id.playerName);

                if (!string.IsNullOrWhiteSpace(player.Text))
                {
                    Players.Add(player.Text);
                    Alert.ShowToast("Player added");
                    player.Text = "";
                }
                else
                {
                    Alert.ShowToast("Please fill in a player name", ToastLength.Long);
                }
            };

            return view;
        }
    }
}