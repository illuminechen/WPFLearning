namespace Fasetto.Word.Core
{
    /// <summary>
    /// A view model for the any popup menus
    /// </summary>
    public class BasePopupMenuViewModel:BaseViewModel
    {        
        #region Public Properties

        /// <summary>
        /// The background color of the bubble in ARGB value
        /// </summary>
        public string BubbleBackGround { get; set; }

        /// <summary>
        /// The alignment of the bubble arrow
        /// </summary>
        public ElementHorizontalAlignment ArrowAlignment { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public BasePopupMenuViewModel()
        {
            // Set default values
            // TODO: Move colors into Core and make use of it here
            BubbleBackGround = "ffffff";
            ArrowAlignment = ElementHorizontalAlignment.Left;
        }

        #endregion
    }
}
