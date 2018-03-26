using System;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Input;

namespace Calculator.View
{
    public partial class MainView : UserControl
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var textBox = sender as TextBox;
            char c = Convert.ToChar(e.Text);
            if (Char.IsNumber(c))
                e.Handled = false;
            else if (c == '.')
            {
                if (textBox.Text.Contains('.'))
                    e.Handled = true;
                else
                    e.Handled = false;
            }
            else
                e.Handled = true;

            base.OnPreviewTextInput(e);
        }
    }
}
