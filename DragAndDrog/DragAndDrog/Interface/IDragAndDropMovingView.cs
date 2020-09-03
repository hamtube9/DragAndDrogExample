using System;
using System.Collections.Generic;
using System.Text;

namespace DragAndDrog.Interface
{
   public  interface IDragAndDropMovingView
    {
        double ScreenX { get; set; }
        double ScreenY { get; set; }
    }
}
