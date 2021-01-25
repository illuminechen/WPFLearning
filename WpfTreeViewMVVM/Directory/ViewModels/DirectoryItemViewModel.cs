using PropertyChanged;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;

namespace WpfTreeViewMVVM
{
    [AddINotifyPropertyChangedInterface]
    /// <summary>
    /// A view model for each directory item
    /// </summary>
    public class DirectoryItemViewModel : BaseViewModel, INotifyPropertyChanged
    {

        #region Public Properties

        /// <summary>
        /// The type of the item
        /// </summary>
        public DirectoryItemType Type { get; set; }
        /// <summary>
        /// The absolute path to the item
        /// </summary>
        public string FullPath { get; set; }
        /// <summary>
        /// The name of the directory item
        /// </summary>
        public string Name { get => this.Type == DirectoryItemType.Drive ? this.FullPath : DirectoryStructure.GetFileFolderName(FullPath); }

        /// <summary>
        /// A list of all children contained inside this item
        /// </summary>
        public ObservableCollection<DirectoryItemViewModel> Children { get; set; }

        /// <summary>
        /// Indicates if this item can be expanded
        /// </summary>
        public bool CanExpand { get => this.Type != DirectoryItemType.File; }

        /// <summary>
        /// Indicates if the current item is expanded or not
        /// </summary>
        public bool IsExpanded
        {
            get => this.Children?.Count(f => f != null) > 0;
            set
            {
                // If the UI tells us to expand...
                if (value == true)
                    // Find all children
                    Expand();
                // If the UI tells us to close...
                else
                    this.ClearChildren();

            }
        }

        #endregion

        #region Public Commands

        /// <summary>
        /// The command to expand this item
        /// </summary>
        public ICommand ExpandCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="fullPath">The full path of this item</param>
        /// <param name="type">The type of item</param>
        public DirectoryItemViewModel(string fullPath, DirectoryItemType type)
        {
            // Create commands
            this.ExpandCommand = new RelayCommand(Expand);

            // Set path and type
            this.FullPath = fullPath;
            this.Type = type;

            // Setup the children as needed
            this.ClearChildren();
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Removes all children from the list, adding a dummy item to show the expand icon if required
        /// </summary>
        private void ClearChildren()
        {
            // Clear items
            this.Children = new ObservableCollection<DirectoryItemViewModel>();

            // Show the expand arrow if we are not a file
            if (this.Type != DirectoryItemType.File)
                this.Children.Add(null);
        }

        #endregion
        /// <summary>
        /// Expand this directory and finds all children
        /// </summary>
        private void Expand()
        {
            if (this.Type == DirectoryItemType.File)
                return;

            // Find all children
            var children = DirectoryStructure.GetDirectoryContents(this.FullPath);
            this.Children = new ObservableCollection<DirectoryItemViewModel>(
                                children.Select(content => new DirectoryItemViewModel(content.FullPath, content.Type)));
        }
    }
}
