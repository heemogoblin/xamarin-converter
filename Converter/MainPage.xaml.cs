using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace Converter
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        
        static Measurements mFrom = Measurements.M;
        static Measurements mTo = Measurements.M;

        public MainPage()
        {
            InitializeComponent();
            Init();
            Application.Current.MainPage = new MainPage();

        }

        private void Init()
        {
            BackgroundColor = Color.Cornsilk;

            Ndata_entry.Completed += (s, e) => ConvertUnits();

        }

        private void ConvertUnits()
        {
            float baseVal = (float)Convert.ToDouble(Ndata_entry.Text);//In m
            switch (mFrom)
            {
                case Measurements.KM:
                    baseVal *= 1000;
                    break;
                case Measurements.Miles:
                    baseVal *= 1609.34f;
                    break;
                default:
                    break;
            }
            switch (mTo)
            {
                case Measurements.KM:
                    baseVal /= 1000;
                    break;
                case Measurements.Miles:
                    baseVal /= 1609.34f;
                    break;
                default:
                    break;
            }
            Nresult.Text = Convert.ToString(baseVal);
        }

        private void Picker_SelectedIndexChanged_ConvertTo(object sender, EventArgs e)
        {
            Picker p = sender as Picker;
            switch (p.SelectedIndex)
            {
                case 0: mTo = Measurements.KM; break;
                case 1: mTo = Measurements.M; break;
                case 2: mTo = Measurements.Miles; break;
            }
            ConvertUnits();
        }

        private void Picker_SelectedIndexChanged_ConvertFrom(object sender, EventArgs e)
        {
            Picker p = sender as Picker;
            switch (p.SelectedIndex)
            {
                case 0: mFrom = Measurements.KM; break;
                case 1: mFrom = Measurements.M; break;
                case 2: mFrom = Measurements.Miles; break;
            }
            ConvertUnits();
        }

        private void Nconvert_button_Clicked_Convert(object sender, EventArgs e)
        {
            ConvertUnits();
        }

        private void Hello123(object sender, EventArgs e)
        {

        }
    }
}
