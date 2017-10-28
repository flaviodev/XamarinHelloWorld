using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.logica;


namespace App1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();

            BtnSoma.Clicked += delegate
            {
                int num1 = int.Parse(Numero1.Text);
                int num2 = int.Parse(Numero2.Text);

                int resultado = Matematica.Soma(num1, num2);

                Resultado.Text = "O resultado é " + resultado;
            };


            BtnSubtrai.Clicked += delegate
            {
                int num1 = int.Parse(Numero1.Text);
                int num2 = int.Parse(Numero2.Text);

                int resultado = Matematica.Substrai(num1, num2);

                Resultado.Text = "O resultado é " + resultado;
            };
        }
	}
}