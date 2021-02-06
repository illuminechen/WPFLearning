using System.Collections.Generic;

namespace Fasetto.Word.Core
{

    /// <summary>
    /// The design-time data for a <see cref="MenuViewModel"/>
    /// </summary>
    public class MenuDesignModel : MenuViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static MenuDesignModel Instance => new MenuDesignModel();

        #endregion

        #region Constructor

        public MenuDesignModel()
        {
            Items = new List<MenuItemViewModel>()
            {
                new MenuItemViewModel{Text = "Design time header...", Type= MenuItemType.Header, Icon = IconType.File } ,
                new MenuItemViewModel{Text = "Menu Item 1",Icon = IconType.File } ,
                new MenuItemViewModel{Text = "Menu Item 2",Icon = IconType.Picture } ,
            };
        }

        #endregion
    }
}
