using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this.descriptionText.Text);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.weldCheckBox.IsChecked =
                this.weldCheckBox1.IsChecked =
                this.weldCheckBox2.IsChecked =
                this.weldCheckBox3.IsChecked =
                this.weldCheckBox4.IsChecked =
                this.weldCheckBox5.IsChecked =
                this.weldCheckBox6.IsChecked =
                this.weldCheckBox7.IsChecked =
                this.weldCheckBox8.IsChecked =
                this.weldCheckBox9.IsChecked = false;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.LengthText.Text += ((CheckBox)sender).Content.ToString();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.NoteText ==null)
            {
                return;
            }
            var controlCombo = (ComboBox)sender;
            var value = (ComboBoxItem)controlCombo.SelectedValue;
            this.NoteText.Text = (string)value.Content.ToString();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ComboBox_SelectionChanged(this.PurchaseComboBox,null);
        }

        private void SupplyNameText_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.MessText.Text = this.SupplyNameText.Text.ToString();
        }
    }
}
