using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFLearning
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            comboFinish.SelectedIndex = 0;
        }

        private void BtnApply_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The Description is: {txtDesctiption.Text}");
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            this.chkAssembly.IsChecked = false;
            this.chkDrill.IsChecked = false;
            this.chkFold.IsChecked = false;
            this.chkLaser.IsChecked = false;
            this.chkLathe.IsChecked = false;
            this.chkPlasma.IsChecked = false;
            this.chkPurchase.IsChecked = false;
            this.chkRoll.IsChecked = false;
            this.chkSaw.IsChecked = false;
            this.chkWeld.IsChecked = false;
        }

        private void chkbox_Checked(object sender, RoutedEventArgs e)
        {
            txtLength.Text += ((CheckBox)sender).Content;
        }

        private void Finish_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (txtNote == null)
                return;

            var combo = sender as ComboBox;
            var value = combo.SelectedValue as ComboBoxItem;

            txtNote.Text = value.Content.ToString();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtMass.Text = txtSupplier.Text;
        }
    }
}
