using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bani
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Quotes : ContentPage
	{

        private int _index;
        private string[] _quotes = new string[]
        {
            "Oaths are but words, and words are but wind.",
            "There is a role and function for beauty in our time.",
            "I believe in luck: how else can you explain the success of those you dislike?"
        };

		public Quotes ()
		{
			InitializeComponent ();
            bani.Text = _quotes[_index];
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (_index <= _quotes.Length)
            {
                _index++;
            }
               
            bani.Text = _quotes[_index];

        }
    }
}