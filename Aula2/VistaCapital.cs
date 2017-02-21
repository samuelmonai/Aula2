using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace Aula2
{
    [Activity(Label = "VistaCapital")]
    public class VistaCapital : Activity
    {
        double defaultValue;
        protected override void OnCreate(Bundle Bundle)
        {
            base.OnCreate(Bundle);
            SetContentView(Resource.Layout.VistaCapital);
            EditText txtCapitalM = FindViewById<EditText>
                (Resource.Id.txtCapitalM);
            EditText txtCapitalC = FindViewById<EditText>
                (Resource.Id.txtCapitalC);
            ImageView ImagenMex = FindViewById<ImageView>
                (Resource.Id.imageMex);
            ImageView ImagenCol = FindViewById<ImageView>
                (Resource.Id.imageCol);
            Button btnSair = FindViewById<Button>
                (Resource.Id.btnsair);
            try
            {
                txtCapitalC.Text = Intent.GetDoubleExtra("CapitalC", defaultValue).ToString();
                txtCapitalM.Text = Intent.GetDoubleExtra("CapitalM", defaultValue).ToString();
                ImagenMex.SetImageResource(Resource.Drawable.Mexico);
                ImagenCol.SetImageResource(Resource.Drawable.Colombia);

            }
            catch (Exception ex)
            {
                Toast.MakeText
                    (this, ex.Message,
                    ToastLength.Short).Show();
            }

            btnSair.Click += delegate 
            {
                Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
            };
              
        }
    }
}