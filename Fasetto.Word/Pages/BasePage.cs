using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Fasetto.Word
{
    /// <summary>
    /// A base page for all pages to gain base functionality
    /// </summary>
    public class BasePage<VM> : Page where VM : BaseViewModel, new()
    {
        #region Private Members

        /// <summary>
        /// The View Model associated with this page
        /// </summary>
        private VM mViewModel;

        #endregion

        #region Public Properties

        /// <summary>
        /// The animation to play when the page is first loaded
        /// </summary>
        public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideAndFadeInFromRight;

        /// <summary>
        /// The animation to play when the page is first unloaded
        /// </summary>
        public PageAnimation PageUnLoadAnimation { get; set; } = PageAnimation.SlideAndFadeOutToLeft;

        /// <summary>
        /// The time any slide animation take to complete
        /// </summary>
        public float SlideSeconds { get; set; } = 0.8f;

        /// <summary>
        /// The View Model associated with this page
        /// </summary>
        public VM ViewModel
        {
            get => mViewModel;
            set
            {
                // If nothing has changed, return 
                if (mViewModel == value)
                    return;

                // Update the value
                mViewModel = value;

                // Set the data context to this page 
                this.DataContext = mViewModel;
            }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public BasePage()
        {
            if (this.PageLoadAnimation != PageAnimation.None)
                this.Visibility = Visibility.Collapsed;

            this.Loaded += BasePage_Loaded;

            // Create a default View Model
            this.ViewModel = new VM();
        }

        #endregion

        #region Animation Load / Unload

        /// <summary>
        /// Once the page is loaded,perform any required animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BasePage_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            // Animation the page in
            await AnimateIn();
        }

        /// <summary>
        /// Animates this page in
        /// </summary>
        /// <returns></returns>
        public async Task AnimateIn()
        {
            // Make sure we have something to do
            if (this.PageLoadAnimation == PageAnimation.None)
                return;

            switch (this.PageLoadAnimation)
            {
                case PageAnimation.SlideAndFadeInFromRight:

                    // Start the animation
                    await this.SlideAndFadeFromRight(this.SlideSeconds);

                    break;
            }
        }

        /// <summary>
        /// Animates this page out
        /// </summary>
        /// <returns></returns>
        public async Task AnimateOut()
        {
            // Make sure we have something to do
            if (this.PageUnLoadAnimation == PageAnimation.None)
                return;

            switch (this.PageUnLoadAnimation)
            {
                case PageAnimation.SlideAndFadeOutToLeft:

                    // Start the animation
                    await this.SlideAndFadeOutToLeft(this.SlideSeconds);

                    break;
            }
        }

        #endregion
    }
}
