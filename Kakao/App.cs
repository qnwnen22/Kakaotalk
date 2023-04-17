﻿using System.Windows;

namespace Kakao
{
    internal class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Window window = new Window();
            window.Show();
        }
    }
}