namespace Fasetto.Word.Core
{
    /// <summary>
    /// A view model for the any popup menus
    /// </summary>
    public class ChatAttachmentPopupMenuDesignModel : ChatAttachmentPopupMenuViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatAttachmentPopupMenuDesignModel Instance => new ChatAttachmentPopupMenuDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatAttachmentPopupMenuDesignModel()
        {
        }

        #endregion
    }
}
