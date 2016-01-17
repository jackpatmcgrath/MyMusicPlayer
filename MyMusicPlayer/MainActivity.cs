using Android.App;
using Android.OS;
using Android.Content;
using Android.Views;
using System;
using Android.Util;

namespace MyMusicPlayer
{
	[Activity (Label = "My Music Player", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		public static MusicService musicSrv = null;
		public static bool musicBound = false;

		public static readonly String DISPLAY_OPT_KEY = "MenuDisplayOptions";
		public static readonly String SONG_INDEX_KEY = "SongIndexKey";
		public static readonly String MUSIC_ERR_TAG = "MusicErrorLogTag";

		MusicConnection musicConn;
		Intent playIntent;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.Main);

			Songleton.Instance.AllSongs = MusicRetrieval.LoadSongs (this);

			if (savedInstanceState == null) {
				SongListFragment songListFragment = new SongListFragment ();
				MusicControlFragment musicControlFragment = new MusicControlFragment ();
				var trans = FragmentManager.BeginTransaction ();
				trans.Add (Resource.Id.fragment_container, songListFragment);
				trans.Add (Resource.Id.music_controls_container, musicControlFragment);
				trans.Commit ();
			}
		}

		protected override void OnStart ()
		{
			base.OnStart ();
			if (playIntent == null) {
				playIntent = new Intent(this, typeof(MusicService));
				musicConn = new MusicConnection ();
				BindService(playIntent, musicConn, Bind.AutoCreate);
				StartService(playIntent);
			}
		}
			
		protected override void OnDestroy() 
		{
			StopService(playIntent);
			musicSrv = null;
			base.OnDestroy();
		}

		public override void OnAttachedToWindow () 
		{
			base.OnAttachedToWindow();
			try {
				MusicControlFragment.controller.Show (0);
			} catch (Exception e) {
				Log.Error (MUSIC_ERR_TAG, "Error showing media controller", e);
			}
		}

		public override bool OnOptionsItemSelected (IMenuItem item)
		{
			switch (item.ItemId) {
			case Android.Resource.Id.Home:
				FragmentManager.PopBackStack ();
				ActionBar.SetDisplayHomeAsUpEnabled (false);
				return true;  
			default:
				return base.OnOptionsItemSelected (item);
			}
		}

		protected override void OnSaveInstanceState(Bundle outState) 
		{
			base.OnSaveInstanceState(outState);
			outState.PutInt(DISPLAY_OPT_KEY, (int)ActionBar.DisplayOptions);
		}

		protected override void OnRestoreInstanceState(Bundle savedInstanceState) 
		{
			base.OnRestoreInstanceState(savedInstanceState);
			int savedDisplayOpt = savedInstanceState.GetInt(DISPLAY_OPT_KEY);
			if (savedDisplayOpt != 0) {
				ActionBar.DisplayOptions = (ActionBarDisplayOptions)savedDisplayOpt;
			}
		}

		class MusicConnection : Java.Lang.Object, IServiceConnection
		{
			public void OnServiceConnected (ComponentName name, IBinder service)
			{
				var binder = service as MusicBinder;
				if (binder != null) {
					MainActivity.musicSrv = binder.GetService ();
					MainActivity.musicBound = true;
				}
			}

			public void OnServiceDisconnected (ComponentName name)
			{
				MainActivity.musicBound = false;
			}
		}
	}
}