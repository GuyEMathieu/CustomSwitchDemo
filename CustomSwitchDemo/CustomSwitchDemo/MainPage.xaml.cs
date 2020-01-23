using CustomSwitchDemo.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomSwitchDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MySwitch_OnToggle(object sender, EventArgs e)
        {
            var control = (MySwitch)sender;

            DisplayAlert("Alert", $"Switch is toggle: {control.IsSelected}", "OK");
        }
    }
}
