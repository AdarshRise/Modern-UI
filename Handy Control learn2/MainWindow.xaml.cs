


using System;

using HandyControl.Controls;
using HandyControl.Data;
using System.Windows;
using MessageBox = HandyControl.Controls.MessageBox;
//using MessageBox = System.Windows.MessageBox;

namespace Handy_Control_learn2
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void But_Min_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("this is great");
            MessageBox.Ask("This came here");
         

            /*
            Growl.Info(new GrowlInfo
            {
                Message = "we found new version",
                CancelStr = "later",
                ConfirmStr = "lets do this"
            });
            */
        }

        private void But_Close_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MessageBox.Ask("This came here");
            /*
            Growl.Info(new GrowlInfo
            {
                Message = "we found new version",
                CancelStr = "later",
                ConfirmStr = "lets do this"
            });
            */
        }

        private void Test_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            // Message = "Test", Caption = "Url", Button = MessageBoxButton.YesNo, IconBrushKey = ResourceToken.AccentBrush, IconKey = ResourceToken.InfoGeometry, StyleKey = "MessageBoxCustom"

            MessageBox.Show(new MessageBoxInfo
            {
                Message = "show this",
                Caption = "Title",
                Button = MessageBoxButton.YesNo,
                IconBrushKey = ResourceToken.AccentBrush,
                IconKey = ResourceToken.AskGeometry,
                StyleKey = "MessageBoxCustom"
            });

        }
    }
}
