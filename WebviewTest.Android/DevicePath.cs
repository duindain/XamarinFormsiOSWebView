using System;
using Xamarin.Forms;

[assembly: Dependency(typeof(WebviewTest.Droid.DevicePath))]
namespace WebviewTest.Droid
{
    public class DevicePath : IDevicePath
    {
        public string GetPath()
        {
            return "file:///android_asset/";
        }
    }
}
