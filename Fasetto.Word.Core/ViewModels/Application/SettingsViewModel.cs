using System;
using System.Windows.Input;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// 
    /// </summary>
    public class SettingsViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The current users Name
        /// </summary>
        public TextEntryViewModel Name { get; set; }

        /// <summary>
        /// The current users Username
        /// </summary>
        public TextEntryViewModel Username { get; set; }

        /// <summary>
        /// The current users Password
        /// </summary>
        public TextEntryViewModel Password { get; set; }

        /// <summary>
        /// The current users Email
        /// </summary>
        public TextEntryViewModel Email { get; set; }

        #endregion

        #region Public Properties

        /// <summary>
        /// The command to open the settings menu
        /// </summary>
        public ICommand OpenCommand { get; set; }

        /// <summary>
        /// The command to close the settings menu
        /// </summary>
        public ICommand CloseCommand { get; set; }

        #endregion

        #region Private Members

        #endregion

        #region Constuctor

        /// <summary>
        /// Default constructor
        /// </summary>
        public SettingsViewModel()
        {
            // Create commands
            CloseCommand = new RelayCommand(Close);
            OpenCommand = new RelayCommand(Open);

            // TODO: Remove this with real information pulled from our database in future
            Name = new TextEntryViewModel { Label = "Name", OriginalText = "Luke Malpass" };
            Username = new TextEntryViewModel { Label = "Username", OriginalText = "luke" };
            Password = new TextEntryViewModel { Label = "Password", OriginalText = "********" };
            Email = new TextEntryViewModel { Label = "Email", OriginalText = "contact@anggelsix.com" };
        }

        #endregion

        /// <summary>
        /// Closes the settings menu
        /// </summary>
        public void Close()
        {
            // Close settings menu
            IoC.Application.SettingsMenuVisible = false;
        }

        /// <summary>
        /// Opens the settings menu
        /// </summary>
        public void Open()
        {
            // Open settings menu
            IoC.Application.SettingsMenuVisible = true;
        }

    }
}
