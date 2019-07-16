﻿using FScrollView = Xamarin.Forms.ScrollView;
using HScrollView = HotUI.ScrollView;
using HView = HotUI.View;
namespace HotUI.Forms.Handlers
{
    public class ScrollViewHandler : FScrollView, FormsViewHandler
    {
        public ScrollViewHandler()
        {
        }

        public Xamarin.Forms.View View => this;
        public object NativeView => View;
        public bool HasContainer { get; set; } = false;

        public void Dispose()
        {

        }

        public void Remove(HView view)
        {

        }

        public void SetView(HView view)
        {
            var scroll = view as HScrollView;
            var newContent = scroll.View?.ToForms();
            if (Content == newContent)
                return;
            this.Content = newContent;
        }

        public void UpdateValue(string property, object value)
        {

        }
    }
}
