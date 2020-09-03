using DragAndDrog.DragAndDrogExtension;
using DragAndDrog.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DragAndDrog.Control
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MovingView : Grid, IDragAndDropMovingView
    {

        public BindableProperty TextProPerty = BindableProperty.Create(
       nameof(Text),
       typeof(string),
       typeof(MovingView),
       default(string),
       BindingMode.OneWay
       );

        public string Text
        {
            set => SetValue(TextProPerty, value);
            get => (string)GetValue(TextProPerty);
        }

        public MovingView()
        {
            InitializeComponent();

        }

        protected override void OnParentSet()
        {
            base.OnParentSet();
            this.InitializeDragAndDrop();
        }


        public double ScreenX { set; get; }
        public double ScreenY { set; get; }
    }
}