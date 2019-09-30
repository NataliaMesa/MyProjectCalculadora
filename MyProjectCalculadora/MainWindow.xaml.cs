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

namespace MyProjectCalculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ResultadoTextBox.IsReadOnly = true;
        }

        private void SumaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (ResultadoTextBox != null)
            {
                try
                {
                    ResultadoTextBox.Text = (Convert.ToDouble(Operando1TextBox.Text) + Convert.ToDouble(Operando2TextBox.Text)).ToString();
                }
                catch (FormatException e1)
                {
                    ResultadoTextBox.Text = e1.Message;
                }
            }
        }

        private void RestaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (ResultadoTextBox != null)
            {
                try
                {
                    ResultadoTextBox.Text = (Convert.ToDouble(Operando1TextBox.Text) - Convert.ToDouble(Operando2TextBox.Text)).ToString();
                }
                catch (FormatException e1)
                {
                    ResultadoTextBox.Text = e1.Message;
                }

            }
        }

        private void MultiplicacionRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (ResultadoTextBox != null)
            {
                try
                {
                    ResultadoTextBox.Text = (Convert.ToDouble(Operando1TextBox.Text) * Convert.ToDouble(Operando2TextBox.Text)).ToString();
                }
                catch (FormatException e1)
                {
                    ResultadoTextBox.Text = e1.Message;
                }

            }
        }

        private void DivisionRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (ResultadoTextBox != null)
            {
                try
                {
                    ResultadoTextBox.Text = Operando2TextBox.Text != "0" ? (Convert.ToDouble(Operando1TextBox.Text) / Convert.ToDouble(Operando2TextBox.Text)).ToString() : "Error";
                }
                catch (FormatException e1)
                {
                    ResultadoTextBox.Text = e1.Message;
                }
            }
        }


        private void Operando1TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            OperacionesARealizar();
        }

        private void Operando2TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            OperacionesARealizar();
        }

        private void OperacionesARealizar()
        {
            if (ResultadoTextBox != null)
            {
                try
                {
                    if ((bool)SumaRadioButton.IsChecked)
                    {
                        ResultadoTextBox.Text = (Convert.ToDouble(Operando1TextBox.Text) + Convert.ToDouble(Operando2TextBox.Text)).ToString();
                    }
                    else if ((bool)RestaRadioButton.IsChecked)
                    {
                        ResultadoTextBox.Text = (Convert.ToDouble(Operando1TextBox.Text) - Convert.ToDouble(Operando2TextBox.Text)).ToString();
                    }
                    else if ((bool)MultiplicacionRadioButton.IsChecked)
                    {
                        ResultadoTextBox.Text = (Convert.ToDouble(Operando1TextBox.Text) * Convert.ToDouble(Operando2TextBox.Text)).ToString();
                    }
                    else
                    {
                        ResultadoTextBox.Text = Operando2TextBox.Text != "0" ? (Convert.ToDouble(Operando1TextBox.Text) / Convert.ToDouble(Operando2TextBox.Text)).ToString() : "Error";
                    }
                }
                catch (FormatException e)
                {
                    ResultadoTextBox.Text = e.Message;
                }
            }
        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            if (ResultadoTextBox != null)
            {
                Operando1TextBox.Text = "0";
                Operando2TextBox.Text = "0";
                ResultadoTextBox.Text = "0";

                SumaRadioButton.IsChecked = true;
            }
        }
    }
}
