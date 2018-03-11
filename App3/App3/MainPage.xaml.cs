using Sockets.Plugin;
using System;
using System.Diagnostics;
using System.Text;
using Xamarin.Forms;
using System.Runtime.InteropServices;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void CustomButton_Pressed(object sender, EventArgs e)
 
        {
            UDPClientAsync(((Button)sender).Text);
        }

        private void CustomButton_Released(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(((Button)sender).Text +" release "+((Button)sender).CommandParameter);
        }

        public async void UDPClientAsync(String botonPresionado)
        {
            var port = 11000;
            var address = "192.168.137.1";
            var client = new UdpSocketClient();
            // convert our greeting message into a byte array
            var msgBytes = Encoding.UTF8.GetBytes(botonPresionado);
            // send to address:port, no guarantee that anyone is there  or that the message is delivered.
            await client.SendToAsync(msgBytes, address, port);
        }

    }
}
