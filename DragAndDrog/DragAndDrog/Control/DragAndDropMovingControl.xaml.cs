using DragAndDrog.DragAndDrogExtension;
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
    public partial class DragAndDropMovingControl : Grid, IDragAndDropMovingView
    {

        public BindableProperty TextProPerty = BindableProperty.Create(
        nameof(Text),
        typeof(string),
        typeof(DragAndDropMovingControl),
        default(string),
        BindingMode.TwoWay
        );

        public string Text
        {
            set => SetValue(TextProPerty, value);
            get => (string)GetValue(TextProPerty);
        }


        public DragAndDropMovingControl()
        {
            InitializeComponent();
            this.InitializeDragAndDrop();

        }

        public double ScreenX { set; get; }
        public double ScreenY { set; get; }
    }
}