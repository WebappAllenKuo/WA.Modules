using System;
using System.Collections.Generic;

namespace WA.Modules.ImageHelper
{
    public class ImageResizer
    {
    }

    public class ImageResizeSettings
    {
        private Dictionary<string, ImageResizeSetting> Settings = new Dictionary<string, ImageResizeSetting>();

        public ImageResizeSetting GetSetting(string key)
        {
            return this.Settings.ContainsKey(key)
                ? Settings[key]
                : new ImageResizeSetting();
        }
    }

    public class ImageResizeSetting
    {
        public int NewWidth { get; set; }
        public int newHeight { get; set; }
        public string NewLocation { get; set; }
    }
}