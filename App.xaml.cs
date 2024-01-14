using Examples;
using System;
using ClickAssistant.ViewModels;
using ClickAssistant.Views;
using Examples;
using GameOverlay;

namespace ClickAssistant;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App
{

    /// <summary>
    /// Application Entry for ClickAssistant
    /// </summary>
    public App()
    {
        var view = new MainView
        {
            DataContext = Activator.CreateInstance<MainViewModel>()
        };
            
        //view.Show();

        //public static void Main(string[] _)

        GameOverlay.TimerService.EnableHighPrecisionTimers();

        using (var example = new Example())
        {
            example.Run();
        }
    }

}
