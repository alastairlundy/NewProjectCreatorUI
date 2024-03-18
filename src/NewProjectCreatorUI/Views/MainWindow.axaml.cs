using System;
using System.Collections.Generic;
using System.IO;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using LocalizationKit.Providers;
using SettingsKit;

namespace NewProjectCreatorUI.Views;

public partial class MainWindow : Window
{
    private SettingsManager<string> _settingsManager;

    private Dictionary<string, string> _launcherSettings;

    public MainWindow()
    {
        InitializeComponent();
        
        _settingsManager = new SettingsManager<string>();
        var launcherSettingsFile = new SettingsFile(Environment.CurrentDirectory + Path.DirectorySeparatorChar + "Resources" + Path.DirectorySeparatorChar + "Settings" + Path.DirectorySeparatorChar + "LauncherSettings.json", new JsonLocalizationFileProvider());

        _launcherSettings = launcherSettingsFile.Get();
      //  TitleLabel = 
        
        LoadSettings();
    }

    
    private void LoadSettings()
    {
        
        this.Height = 600;
        this.Width = 800;


        //    this.Width = double.Parse(_launcherSettings["Width.Default"]);
        //   this.Height = double.Parse(_launcherSettings["Height.Default"]);
    }

    private void ContinueLink_OnTapped(object? sender, TappedEventArgs e)
    {
     
    }

    private void CloneRepositoryButton_OnClick(object? sender, RoutedEventArgs e)
    {
      
    }
}