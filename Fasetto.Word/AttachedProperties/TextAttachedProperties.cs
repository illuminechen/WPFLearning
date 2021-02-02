﻿using System.Windows;
using System.Windows.Controls;

namespace Fasetto.Word
{
     /// <summary>
    /// Focuses (keyboard focus) this element on load
    /// </summary>
    public class IsFocusProperty : BaseAttachedProperty<IsFocusProperty, bool>
    {
        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            // If we don't have a control, return
            if (!(sender is Control control))
                return;

            // Focus this control once loaded 
            control.Loaded += (s, se) => control.Focus();
        }
    }
}