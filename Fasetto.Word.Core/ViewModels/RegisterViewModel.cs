using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// The View Model for Register page
    /// </summary>
    public class RegisterViewModel : BaseViewModel
    {
        #region Private Member


        #endregion

        #region Public Properties

        /// <summary>
        /// Email of the user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// A flag indicating if the login command is running
        /// </summary>
        public bool LoginIsRunning { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// The command to login
        /// </summary>
        public ICommand LoginCommand { get; set; }

        /// <summary>
        /// The command to register
        /// </summary>
        public ICommand RegisterCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Deafult Constructor
        /// </summary>
        /// <param name="window"></param>
        public RegisterViewModel()
        {
            // Create commands
            RegisterCommand = new RelayParameterizedCommand(async (parameter) => await RegisterAsync(parameter));
            LoginCommand = new RelayCommand(async () => await LoginAsync());
        }

        /// <summary>
        /// Attemps to log the user in
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString"/> passed in from the view for the users password</param>
        /// <returns></returns>
        public async Task RegisterAsync(object parameter)
        {
            await RunCommand(() => LoginIsRunning, async () =>
             {
                 await Task.Delay(500);
             });
        }

        /// <summary>
        /// Take the user to the register page
        /// </summary>
        /// <returns></returns>
        public async Task LoginAsync()
        {
            // TODO: Go to register page?
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.Login);

            await Task.Delay(1);
        }

        #endregion
    }
}
