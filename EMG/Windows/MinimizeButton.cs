using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EMG.Windows
{
    public class MinimizeButton : CaptionButton
    {
        static MinimizeButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MinimizeButton), new FrameworkPropertyMetadata(typeof(MinimizeButton)));
        }

        protected override void OnClick()
        {
            base.OnClick();
            SystemCommands.MinimizeWindow(Window.GetWindow(this));
        }
    }
}
