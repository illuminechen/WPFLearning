using PropertyChanged;
using System.ComponentModel;

namespace WpfTreeViewMVVM
{
    /// <summary>
    /// A base view model fires Property changed events as needed
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// The event that is fired when any child property changes its value
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };
    }
}
