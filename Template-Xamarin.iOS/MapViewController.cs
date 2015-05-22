using CoreLocation;
using Foundation;
using MapKit;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Template_Xamarin.iOS
{
    partial class MapViewController : UIViewController
    {
        CLLocationManager m_LocationManager = new CLLocationManager();
        public MapViewController(IntPtr handle) : base(handle)
        {
        }

        private string m_PointAnnotationId = "YES";

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //Map_Map.MapType = MapKit.MKMapType.Standard;

            if (UIDevice.CurrentDevice.CheckSystemVersion(8, 0))
            {
                m_LocationManager.RequestWhenInUseAuthorization();
            }
            Map_Map.ShowsUserLocation = true;
            MKPointAnnotation oPointAnnotation = new MKPointAnnotation
            {
                Title = "¸Î¶©¹q¯à",
            };
            oPointAnnotation.SetCoordinate(new CLLocationCoordinate2D(24.977109, 121.545983));
            Map_Map.AddAnnotation(oPointAnnotation);
            Map_Map.GetViewForAnnotation = delegate (MKMapView mapView, IMKAnnotation annotation)
             {
                 if (annotation is MKPointAnnotation)
                 {
                     MKPinAnnotationView pinAnnotationView = (MKPinAnnotationView)Map_Map.DequeueReusableAnnotation(m_PointAnnotationId);
                     if (pinAnnotationView == null)
                     {
                         pinAnnotationView = new MKPinAnnotationView(annotation, m_PointAnnotationId);
                         pinAnnotationView.PinColor = MKPinAnnotationColor.Purple;
                         pinAnnotationView.CanShowCallout = true;
                         pinAnnotationView.RightCalloutAccessoryView = UIButton.FromType(UIButtonType.DetailDisclosure);
                     }
                     return pinAnnotationView;
                 }
                 return null;
             };


            //Map_Map.SetUserTrackingMode(MKUserTrackingMode.None, true);
            Map_Map.ShowAnnotations(new IMKAnnotation[] { oPointAnnotation }, true);


        }
    }
}
