using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace FFTafelvoetbal
{
    public static class Players
    {
        private static List<string> _players;

        static Players()
        {
            _players = new List<string>();
        }

        public static void Add(string player)
        {
            _players.Add(player);
        }

        public static void Remove(string player)
        {
            _players.Remove(player);
        }

        public static List<string> Get()
        {
            return _players;
        }
    }
}