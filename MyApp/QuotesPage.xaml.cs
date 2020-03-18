using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        public QuotesPage()
        {
            InitializeComponent();

            //slider.Value = 0.5;
        }
        private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            label.Text = String.Format("Font Size: {0}", e.NewValue);
            text.FontSize = e.NewValue;
        }

        int i = 1;
        private void Button_Clicked(object sender, EventArgs e)
        {            
            string[] quotes = { "Persistence is very important. You should not give up unless you're forced to give up.",
                                "Innovation distinguishes between a leader and a follower.",
                                "If you're changing the world, you're working on important things. You're excited to get up in the morning.",
                                "I think a simple rule of business is, if you do the things that are easier first, then you can actually make a lot of progress.",
                                "Your most unhappy customers are your greatest source of learning.",
                                "A brand for a company is like a reputation for a person. You earn reputation by trying to do hard things well.",
                                "Surround yourself with great people.",
                                "Solving big problems is easier than solving little problems.",
                                "Focusing is about saying 'No.' And when you say 'No,' you piss off people."};

            if (i >= quotes.Length) {
                i = 0;
            }
            text.Text = quotes[i++];
            Console.Out.WriteLine(i);
        }
    }
}