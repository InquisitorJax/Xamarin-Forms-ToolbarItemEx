using Xamarin.Forms;

namespace XamarinForms
{
    public class ToolbarItemEx : ToolbarItem
    {
        //NOTE: Default value is true, because toolbar items are by default visible when added to the Toolbar
        public static readonly BindableProperty IsVisibleProperty = BindableProperty.Create("IsVisible", typeof(bool), typeof(ToolbarItemEx), true, BindingMode.TwoWay, null, OnIsVisibleChanged);

        public bool IsVisible
        {
            get { return (bool)GetValue(IsVisibleProperty); }
            set { SetValue(IsVisibleProperty, value); }
        }

        public ContentPage ParentPage
        {
            get { return Parent as ContentPage; }
        }

        private static void OnIsVisibleChanged(BindableObject bindable, bool oldvalue, bool newvalue)
        {
            var item = bindable as ToolbarItemEx;

            if (item.ParentPage == null)
                return;

            var items = item.ParentPage.ToolbarItems;

            if (newvalue && !items.Contains(item))
            {
                items.Add(item);
            }
            else if (!newvalue && items.Contains(item))
            {
                items.Remove(item);
            }
        }
    }
}