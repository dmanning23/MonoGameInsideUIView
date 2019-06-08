using Foundation;
using System;
using UIKit;

namespace MonoGameInsideUIView.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController (IntPtr handle) : base (handle)
        {
        }

		public void RunGame()
		{
			var game = new Game1(Finish);

			game.Run();
		}

		public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			RunGame();
		}

		public void Finish()
		{
			this.DismissViewController(false, null);
		}

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}