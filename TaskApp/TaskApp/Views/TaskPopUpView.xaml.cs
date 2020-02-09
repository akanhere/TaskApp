using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskPopUpView : ContentView
    {
        public double PageHeaderHeight { get; private set; } = 80;
        public delegate void TapHandler();
        public TaskPopUpView()
        {
            InitializeComponent();
        }
        public TapHandler OnExpand { get; set; }
        public TapHandler OnCollapse { get; set; }

        private void OnExpandTapped(object sender, EventArgs args)
        {
            ToggleState("Expanded");
            OnExpand?.Invoke();
        }
        private void OnCollapseTapped(object sender, EventArgs args)
        {
            ToggleState("Collapsed");
            OnCollapse?.Invoke();
        }
        void ToggleState(string state)
        {
            VisualStateManager.GoToState(ExpandButton, state);
            VisualStateManager.GoToState(CollapseButton, state);
        }
    }
}