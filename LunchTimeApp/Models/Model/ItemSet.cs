using System;

namespace LunchTimeApp.Models.Model
{
    public class ItemSet
    {
        public int ItemValue { get; set; }
        public string ItemDisp { get; set; }
        public ItemSet(int value, string display)
        {
            ItemValue = value;
            ItemDisp = display;
        }
    }
}
