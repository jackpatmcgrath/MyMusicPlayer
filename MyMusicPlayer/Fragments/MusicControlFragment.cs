
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace MyMusicPlayer
{
	public class MusicControlFragment : Fragment, MediaController.IMediaPlayerControl
	{
		public static MusicController controller { get; private set; }

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			View view = inflater.Inflate (Resource.Layout.MusicControls, container, false);
			initController (view);
			return view;
		}

		void initController(View v)
		{
			controller = new MusicController (Activity);
			controller.NextClick += delegate {
				//playNext();
			};
			controller.PreviousClick += delegate {
				//playPrev();
			};
			controller.SetMediaPlayer (this);
			controller.SetAnchorView (v);
			controller.Enabled = true;
		}
			
		public bool CanPause ()
		{
			return true;
		}

		public bool CanSeekBackward ()
		{
			return true;
		}

		public bool CanSeekForward ()
		{
			return true;
		}

		public void Pause ()
		{
		}

		public void SeekTo (int pos)
		{
		}

		public void Start ()
		{
		}

		public int AudioSessionId {
			get {
				return 0;
			}
		}
		public int BufferPercentage {
			get {
				return 0;
			}
		}

		public int CurrentPosition {
			get {
				return 0;
			}
		}

		public int Duration {
			get {
				return 0;
			}
		}

		public bool IsPlaying {
			get {
				return true;
			}
		}
	}
}

