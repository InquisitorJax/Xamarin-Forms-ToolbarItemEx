using Prism.Mvvm;

namespace XamarinForms
{
    public class MainPageViewModel : BindableBase
    {
        private bool _toolbarItem1Visible;
        private bool _toolbarItem2Visible;

        public MainPageViewModel()
        {
            ToolbarItem1Visible = true;
            ToolbarItem2Visible = true;
        }

        public bool ToolbarItem1Visible
        {
            get { return _toolbarItem1Visible; }
            set { SetProperty(ref _toolbarItem1Visible, value); }
        }

        public bool ToolbarItem2Visible
        {
            get { return _toolbarItem2Visible; }
            set { SetProperty(ref _toolbarItem2Visible, value); }
        }
    }
}