﻿using Eto.Forms;
using System;

namespace DotDevelop.Gtk
{
    internal class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            new Application(Eto.Platforms.Gtk).Run(new MainForm());
        }
    }
}
