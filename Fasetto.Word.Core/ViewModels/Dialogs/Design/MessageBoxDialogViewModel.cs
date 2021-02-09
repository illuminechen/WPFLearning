namespace Fasetto.Word.Core
{
    /// <summary>
    /// Detials for a message box dialog
    /// </summary>
    public class MessageBoxDialogDesignModel : MessageBoxDialogViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static MessageBoxDialogDesignModel Instance => new MessageBoxDialogDesignModel();

        #endregion

        #region Constructor

        public MessageBoxDialogDesignModel()
        {
            OkText = "OK";
            Message = "Design Time messages are fun :)";
        }

        #endregion

    }
}
