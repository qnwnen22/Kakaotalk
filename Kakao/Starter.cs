﻿using Kakao.Settings;
using System;

namespace Kakao
{
    internal class Starter
    {
        [STAThread]
        public static void Main(string[] args)
        {
            _ = new App()
                .AddInversionModule<ViewModules>()
                .AddInversionModule<DirectModules>()
                .AddWireDataContext<WireDataContext>()
                .Run();
        }
    }
}
