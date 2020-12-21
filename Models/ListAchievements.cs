﻿using PluginCommon;
using System;
using System.Windows.Media.Imaging;

namespace SuccessStory.Models
{
    /// <summary>
    /// Class for the ListBox achievements
    /// </summary>
    public class ListBoxAchievements
    {
        public string Icon { get; set; }
        public string IconImage { get; set; }
        public bool IsGray { get; set; }
        public bool EnableRaretyIndicator { get; set; }
        public string Name { get; set; }
        public DateTime? DateUnlock { get; set; }
        public string Description { get; set; }
        public float Percent { get; set; }
        public string NameWithDateUnlock
        {
            get
            {
                string NameWithDateUnlock = Name;

                if (DateUnlock != null && DateUnlock != default(DateTime))
                {
                    var converter = new LocalDateTimeConverter();
                    NameWithDateUnlock += " (" + converter.Convert(DateUnlock, null, null, null) + ")";
                }

                return NameWithDateUnlock;
            }
        }
    }
}
