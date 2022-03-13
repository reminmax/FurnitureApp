using Android.Content;
using FurnitureApp.Droid;
using FurnitureApp.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Widget;

[assembly: ExportRenderer(typeof(SearchBarWithoutUnderline), typeof(SearchBarWithoutUnderlineRenderer))]
namespace FurnitureApp.Droid
{
    public class SearchBarWithoutUnderlineRenderer : SearchBarRenderer
    {
        public SearchBarWithoutUnderlineRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<SearchBar> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var plateId = Resources.GetIdentifier("android:id/search_plate", null, null);
                var plate = Control.FindViewById(plateId);
                plate.SetBackgroundColor(Android.Graphics.Color.Transparent);

                var icon = Control?.FindViewById(Context.Resources.GetIdentifier("android:id/search_mag_icon", null, null));
                (icon as ImageView)?.SetColorFilter(Android.Graphics.Color.Rgb(64, 59, 88));

            }
        }
    }
}