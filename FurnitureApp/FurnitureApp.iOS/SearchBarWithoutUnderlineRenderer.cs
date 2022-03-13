using Foundation;
using FurnitureApp.Controls;
using FurnitureApp.iOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(SearchBarWithoutUnderline), typeof(SearchBarWithoutUnderlineRenderer))]
namespace FurnitureApp.iOS
{
   
    public class SearchBarWithoutUnderlineRenderer : SearchBarRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<SearchBar> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var searchbar = (UISearchBar)Control;
                searchbar.TintColor = UIColor.FromRGB(64, 59, 88);
            }
        }
    }
}