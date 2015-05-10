// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Template_Xamarin.iOS
{
	[Register ("MapViewController")]
	partial class MapViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel Label_MapCaption { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		MapKit.MKMapView Map_Map { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (Label_MapCaption != null) {
				Label_MapCaption.Dispose ();
				Label_MapCaption = null;
			}
			if (Map_Map != null) {
				Map_Map.Dispose ();
				Map_Map = null;
			}
		}
	}
}
