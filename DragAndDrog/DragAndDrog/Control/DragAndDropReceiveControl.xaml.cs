using DragAndDrog.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DragAndDrog.Control.NewFolder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DragAndDropReceiveControl : Grid, IDragAndDropHoverableView, IDragAndDropReceivingView
    {

        public BindableProperty TextProPerty = BindableProperty.Create(
    nameof(Text),
    typeof(string),
    typeof(DragAndDropReceiveControl),
    default(string),
    BindingMode.OneWay

    );

        public string Text
        {
            set => SetValue(TextProPerty, value);
            get => (string)GetValue(TextProPerty);
        }


        public DragAndDropReceiveControl()
        {
            InitializeComponent();
        }

        public void OnDropReceived(IDragAndDropMovingView view)
        {
            if (view is DragAndDropMovingControl sender)
            {
                BackgroundColor = sender.BackgroundColor;
                this.Text = sender.Text;
            }

        }

        public void OnHovered(List<IDragAndDropMovingView> views)
        {
            Opacity = views.Any() ? .3 : 1;
        }
    }
}