using System;
using Foundation;
using Xamarin.Forms;

[assembly: Dependency(typeof(WebviewTest.iOS.DevicePath))]
namespace WebviewTest.iOS
{
    public class DevicePath : IDevicePath
    {
        public string GetPath()
        {
            return NSBundle.MainBundle.BundlePath;
        }
    }
}
