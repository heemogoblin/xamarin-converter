using System;
using Gtk;
using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;

namespace Converter.GTK
{
    class MainClass
    { 
        public static void Main(string[] args)
        {
            Gtk.Application.Init();
            Forms.Init();
            Xamarin.Forms.Application app = new Converter.App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("Converter GTK#");
            window.Show();
            Gtk.Application.Run();
        }
    }
}
