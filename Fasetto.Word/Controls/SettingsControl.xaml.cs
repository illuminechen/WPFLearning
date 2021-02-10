using Fasetto.Word.Core;
using System.Windows.Controls;

namespace Fasetto.Word
{
    /// <summary>
    /// SettingsControl.xaml 的互動邏輯
    /// </summary>
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();


            // Set data context to settings view model
            DataContext = IoC.Settings;
        }
    }
}
