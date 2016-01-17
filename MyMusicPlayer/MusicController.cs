using System;
using Android.Widget;
using Android.Content;
using Android.Util;
using Android.Views;
using Android.App;

namespace MyMusicPlayer
{
	public class MusicController : MediaController
	{
		public MusicController (Context c) : base (c)
		{
		}

		public override void Hide ()
		{
		}

		public override bool DispatchKeyEvent (KeyEvent ev) 
		{
			if (ev.KeyCode == Keycode.Back && ev.Action == KeyEventActions.Up) 
			{
				var a = Context as Activity;
				int count = a.FragmentManager.BackStackEntryCount;
				if (count == 0) {
					a.MoveTaskToBack(true);
				} else {
					a.FragmentManager.PopBackStack ();
					a.ActionBar.SetDisplayHomeAsUpEnabled (false);
				}
			}
			return base.DispatchKeyEvent(ev);
		}
	}
}

