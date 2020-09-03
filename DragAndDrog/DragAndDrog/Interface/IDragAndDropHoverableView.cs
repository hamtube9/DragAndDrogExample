using System;
using System.Collections.Generic;
using System.Text;

namespace DragAndDrog.Interface
{
  public  interface IDragAndDropHoverableView
    {
        void OnHovered(List<IDragAndDropMovingView> views);
    }
}
