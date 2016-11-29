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
using Newtonsoft.Json;


namespace NapierBankMessage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        public void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string input = new TextRange(inBody.Document.ContentStart, inBody.Document.ContentEnd).Text;

           

            if (input.Substring(0, 1) == "E")
            {
                
                ParseEmail.parseEmail(input);
            }
            else if (input.Substring(0, 1) == "S")
            {
                ParseSMS.parseSMS(input);
            }
            else if (input.Substring(0, 1) == "T")
            {
                ParseTweet.parseTweet(input);
            }
            else
                MessageBox.Show("Could not determine message type, please try again.");
            MessageBox.Show("Message Submitted");
            inBody.Document.Blocks.Clear();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
           review.Document.Blocks.Add(new Paragraph(new Run(Reader.readFile("emails.json"))));
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}