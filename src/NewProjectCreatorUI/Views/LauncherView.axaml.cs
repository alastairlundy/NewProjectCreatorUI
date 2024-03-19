using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Platform.Storage;

namespace NewProjectCreatorUI.Views;

public partial class LauncherView : UserControl
{
    public LauncherView()
    {
        InitializeComponent();
    }

    private void CloneRepositoryButton_OnClick(object? sender, RoutedEventArgs e)
    {
      
    }

    private void ContinueLink_OnTapped(object? sender, TappedEventArgs e)
    {
       
    }

    private void CreateNewProjectButton_OnClick(object? sender, RoutedEventArgs e)
    {
       
    }

    private void OpenFolderButton_OnClick(object? sender, RoutedEventArgs e)
    {
        // Get top level from the current control. Alternatively, you can use Window reference instead.
        var topLevel = TopLevel.GetTopLevel(this);

        var folders = topLevel.StorageProvider.OpenFolderPickerAsync(new FolderPickerOpenOptions
        {
            Title = "",
            AllowMultiple = true
        }); 
    }

    private void OpenProjectButton_OnClick(object? sender, RoutedEventArgs e)
    {
        var topLevel = TopLevel.GetTopLevel(this);

        var file = topLevel.StorageProvider.OpenFilePickerAsync(new FilePickerOpenOptions
        {
            Title = "",
            AllowMultiple = false,
        });
    }
}