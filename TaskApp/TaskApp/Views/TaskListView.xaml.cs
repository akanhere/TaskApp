using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskListView : ContentPage
    {
        double _pageHeight;
        public TaskListView()
        {
            InitializeComponent();

            BindingContext = new TaskListViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Popup.OnExpand += OnExpand;
            Popup.OnCollapse += OnCollapse;
        }

        private void OnCollapse()
        {
            Popup.TranslateTo(0, _pageHeight - Popup.PageHeaderHeight, 500);
        }

        private void OnExpand()
        {
            var height = _pageHeight - Popup.PageHeaderHeight;
            Popup.TranslateTo(0, Height - height, 500);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Popup.OnExpand -= OnExpand;
            Popup.OnCollapse -= OnCollapse;
        }
        protected override void OnSizeAllocated(double width, double height)
        {
            _pageHeight = height;
            Popup.TranslationY = _pageHeight - Popup.PageHeaderHeight;
            base.OnSizeAllocated(width, height);
        }
    }
}