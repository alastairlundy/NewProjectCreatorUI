using System;
using System.Collections.Generic;
using System.IO;
using Avalonia.Controls;
using SettingsKit;
using SettingsKit.Providers;

namespace NewProjectCreatorUI.Views;

public partial class MainWindow : Window
{
    private SettingsManager<string> _settingsManager;

    private SettingsFile<string> _launcherSettingsFile;
    
    public MainWindow()
    {
        InitializeComponent();
        
        _settingsManager = new SettingsManager<string>();
        var launcherSettingsFile = new SettingsFile<string>(Environment.CurrentDirectory + Path.DirectorySeparatorChar + "Resources" + Path.DirectorySeparatorChar + "Settings" + Path.DirectorySeparatorChar + "LauncherSettings.json", new JsonSettingsFileProvider<string>());
        
        LoadSettings();
    }

    private void LoadSettings()
    {
        this.Width = double.Parse(_launcherSettingsFile.Get("Width.Default"));
        this.Height = double.Parse(_launcherSettingsFile.Get("Height.Default"));
    }
}