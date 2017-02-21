using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace Aula2
{
    [Activity(Label = "Aula2", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        double IngresoColo, IngresoMex, EgresoColo, EgresoMex, CapitalM, CapitalC;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            Button btnCalcular = FindViewById<Button>
                (Resource.Id.btncalcular);
            EditText txtIngColo = FindViewById<EditText>
                (Resource.Id.txtIngrColo);
            EditText txtEgrColo = FindViewById<EditText>
                (Resource.Id.txtEgrColo);
            EditText txtIngMex = FindViewById<EditText>
                (Resource.Id.txtIngrMex);
            EditText txtEgrMex = FindViewById<EditText>
                (Resource.Id.txtEgrMex);

            
            btnCalcular.Click += delegate
            {
                try
                {
                    IngresoColo = double.Parse(txtIngColo.Text);
                    IngresoMex = double.Parse(txtIngMex.Text);
                    EgresoColo = double.Parse(txtEgrColo.Text);
                    EgresoMex = double.Parse(txtEgrMex.Text);
                    CapitalM = IngresoMex - EgresoMex;
                    CapitalC = IngresoColo - EgresoColo;
                    Carga();
                }
                catch (System.Exception ex)
                {
                    Toast.MakeText(this, ex.Message,
                    ToastLength.Short).Show();
                    throw;
                }
            };
           
        }
        public void Carga()
        {
            Intent objIntent = new Intent(this,
                typeof(VistaCapital));
            objIntent.PutExtra("CapitalM", CapitalM);
            objIntent.PutExtra("CapitalC", CapitalC);
            StartActivity(objIntent);
        }
    }
}

