using System.Collections.Generic;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// A view model for the any popup menus
    /// </summary>
    public class ChatAttachmentPopupMenuViewModel : BasePopupMenuViewModel
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatAttachmentPopupMenuViewModel()
        {
            Content = new MenuViewModel
            {
                Items = new List<MenuItemViewModel>()
                {
                    new MenuItemViewModel{Text = "Attach a file...", Type= MenuItemType.Header, Icon = IconType.File } ,
                    new MenuItemViewModel{Text = "From Computer",Icon = IconType.File } ,
                    new MenuItemViewModel{Text = "From Pictures",Icon = IconType.Picture } ,
                }
            };

        }

        #endregion
    }
}
