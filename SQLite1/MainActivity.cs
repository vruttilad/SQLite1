using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace SQLite1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText name, surname, marks, id;
        Button add, view;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            name = FindViewById<EditText>(Resource.Id.editText1);
            surname = FindViewById<EditText>(Resource.Id.editText2);
            marks = FindViewById<EditText>(Resource.Id.editText3);
            id = FindViewById<EditText>(Resource.Id.editText4);

            add = FindViewById<Button>(Resource.Id.button1);
            view = FindViewById<Button>(Resource.Id.button1);

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}