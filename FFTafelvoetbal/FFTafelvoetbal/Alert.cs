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
    public static class Alert
    {
        private static Context _context;

        public static void AddContext(Context context)
        {
            _context = context;
        }

        public static void ShowAlert(string title, string content)
        {
            var alert = new AlertDialog.Builder(_context);
            alert.SetTitle(title);
            alert.SetMessage(content);
            alert.SetPositiveButton("Ok", (senderAlert, args) => { });

            var dialog = alert.Create();
            dialog.Show();
        }

        public static void ShowToast(string content, ToastLength length = ToastLength.Short)
        {
            var toast = Toast.MakeText(_context, content, length);
            toast.SetGravity(GravityFlags.Center, 0, 0);
            toast.Show();
        }
    }
}