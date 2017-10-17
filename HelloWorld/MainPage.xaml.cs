using System;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HelloWorld
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //public class TINT tint;




        public MainPage()
        {
            this.InitializeComponent();
            //tint = new List<winTint>()
            //{
            //    TINT.winTint.blue,

            //};
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync(txtResults.Text);
            mediaElement.SetSource(stream, stream.ContentType);
            mediaElement.Play();



            //validate text width is numeric


            //validate height is numberic

            CalculateTotals();




        }
        //private void TxtWidth_TextChanging(object sender, System.EventArgs e)
        //
        //}

        private void CalculateTotals()
        {
            //calculate 

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            widthString = TxtWidth.Text;
            width = double.Parse(widthString);


            heightString = txtHeight.Text;
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width + height);


        

            txtResults.Text = "The length of the wood is " + woodLength + " feet \r\n" +
            "The area of the glass is " + glassArea + "square meters \r\n" +
            "you have chosen the color " + ((ComboBoxItem)winTint.SelectedValue).Content + " \r\n " +
            "we will ship you " + slider.Value.ToString() + " windows \r\n" +
            DateTime.Now + " Is your order date";
        }

        private void TxtWidth_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {


            int parsedValue;
            if (!int.TryParse(TxtWidth.Text, out parsedValue))
            {
                TxtWidth.Background = new SolidColorBrush(Colors.Red);
            }
            else
            {
                TxtWidth.Background = new SolidColorBrush(Colors.White);


            }
            return;
        }

        private void txtHeight_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            int parsedValue;
            if (!int.TryParse(txtHeight.Text, out parsedValue))
            {
                txtHeight.Background = new SolidColorBrush(Colors.Red);
            }
            else
            {
                txtHeight.Background = new SolidColorBrush(Colors.White);


            }
            return;
        }
    }
    
    
}
