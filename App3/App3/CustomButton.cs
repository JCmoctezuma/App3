using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    public class CustomButton: Xamarin.Forms.Button
    {

        public event EventHandler Pressed;
        public event EventHandler Released;

        public virtual void OnPressed()
        {
            Pressed?.Invoke(this, EventArgs.Empty);
        }

        public virtual void OnReleased()
        {
            Released?.Invoke(this, EventArgs.Empty);
        }
    }
}
