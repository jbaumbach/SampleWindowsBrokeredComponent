﻿using BrokeredComponent;
using System.Diagnostics;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SampleBrokeredThingy
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Debug.WriteLine("yeah bro, launched and junk");

            Sample b = new Sample();
            Debug.WriteLine(b.Yo());

        }
    }
}
