namespace Fasetto.Word.Core
{
    /// <summary>
    /// The design-time data for a <see cref="TextEntryDesignViewModel"/>
    /// </summary>
    public class TextEntryDesignViewModel : TextEntryViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static TextEntryDesignViewModel Instance => new TextEntryDesignViewModel();

        #endregion

        #region Constructor

        public TextEntryDesignViewModel()
        {
            Label = "Name";
            OriginalText = "Luke Malpass";
            EditedText = "Editing :)";            
        }

        #endregion

    }
}
