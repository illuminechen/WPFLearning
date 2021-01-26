namespace Fasetto.Word
{
    /// <summary>
    /// Styles of page animations for appearing/disappering
    /// </summary>
    public enum PageAnimation
    {
        /// <summary>
        /// No animation takes place
        /// </summary>
        None=0,
        /// <summary>
        /// The pages slides in and fades in from the right
        /// </summary>
        SlideAndFadeInFromRight=1,

        /// <summary>
        /// The pages slides out and fade out to the left
        /// </summary>
        SlideAndFadeOutToLeft=2,
    }
}
