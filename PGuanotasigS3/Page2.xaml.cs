using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PGuanotasigS3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2(string dato1,double dato2)
        {
            InitializeComponent();
            lblDatoUno.Text = "DATO UNO" + dato1;
            lblDatoDos.Text = "DATO DOS" + dato2.ToString();
        }

        private void btnAbrir_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page3());
        }
    }
}