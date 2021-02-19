using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace Fasetto.Word
{
    /// <summary>
    /// TextEntryControl.xaml 的互動邏輯
    /// </summary>
    public partial class TextEntryControl : UserControl
    {
        #region Dependency Properties

        /// <summary>
        /// The label width of control
        /// </summary>
        public GridLength LabelWidth
        {
            get => (GridLength)GetValue(LabelWidthProperty);
            set => SetValue(LabelWidthProperty, value);
        }

        // Using a DependencyProperty as the backing store for LabelWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LabelWidthProperty =
            DependencyProperty.Register("LabelWidth", typeof(GridLength), typeof(TextEntryControl), new PropertyMetadata(GridLength.Auto, LabelWidthChangeCallback));

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public TextEntryControl()
        {
            InitializeComponent();
        }

        #endregion

        #region Dependency Callbacks

        /// <summary>
        /// Called when the label width has changed
        /// </summary>
        /// <param name="d"></param>
        /// <param name="e"></param>
        private static void LabelWidthChangeCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!(d is TextEntryControl control))
                return;
            try
            {
                // Set the column definition width to the new value
                control.LabelColumnDefinition.Width = (GridLength)(e.NewValue);
            }
            catch (Exception ex)
            {
                // Make developer aware of porential issue
                Debugger.Break();
                control.LabelColumnDefinition.Width = GridLength.Auto;
            }
        }

        #endregion
    }
}
