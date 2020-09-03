using System;
using System.Collections.Generic;
using System.Text;

namespace DragAndDrog.Interface
{
   public interface IDragAndDropReceivingView
    {
        void OnDropReceived(IDragAndDropMovingView view);
    }
}
