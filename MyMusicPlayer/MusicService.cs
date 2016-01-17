using System;
using Android.App;
using Android.Media;
using Android.OS;
using Android.Content;
using System.Collections.Generic;
using Android.Provider;
using Android.Util;

namespace MyMusicPlayer
{
	[Service]
	public class MusicService : Service, MediaPlayer.IOnPreparedListener, MediaPlayer.IOnErrorListener, MediaPlayer.IOnCompletionListener
	{
		public int songPos { get; set; }

		MusicBinder binder;
		MediaPlayer player;

		public override void OnCreate ()
		{
			base.OnCreate ();

			songPos = 0;
			player = new MediaPlayer ();
			InitMusicPlayer ();
		}

		void InitMusicPlayer ()
		{
			player.SetWakeMode (Application.Context, WakeLockFlags.Partial);
			player.SetAudioStreamType (Stream.Music);
			player.SetOnPreparedListener (this);
			player.SetOnCompletionListener (this);
			player.SetOnErrorListener (this);
		}

		public override IBinder OnBind (Intent intent)
		{
			binder = new MusicBinder (this);
			return binder;
		}

		public override bool OnUnbind (Intent intent)
		{
			player.Stop ();
			player.Release ();
			return false;
		}

		public void PlaySong ()
		{
			player.Reset ();
			var trackUri = ContentUris.WithAppendedId (MediaStore.Audio.Media.ExternalContentUri, Songleton.Instance[songPos].Id);
			try {
				player.SetDataSource (Application.Context, trackUri);
			} catch (Exception e) {
				Log.Error (MainActivity.MUSIC_ERR_TAG, "Error setting data source", e);
			}
			player.PrepareAsync ();
		}

		public int GetPosn(){
			return player.CurrentPosition;
		}

		public int GetDur(){
			return player.Duration;
		}

		public bool IsPlay(){
			return player.IsPlaying;
		}

		public void PausePlayer(){
			player.Pause();
		}

		public void Seek(int pos){
			player.SeekTo(pos);
		}

		public void Go(){
			player.Start();
		}

		public void OnPrepared (MediaPlayer mp)
		{
			player.Start ();
		}

		public bool OnError (MediaPlayer mp, MediaError what, int extra)
		{
			return false;
		}

		public void OnCompletion (MediaPlayer mp)
		{

		}
	}

	public class MusicBinder : Binder
	{
		MusicService service;

		public MusicBinder (MusicService service)
		{
			this.service = service;
		}

		public MusicService GetService ()
		{
			return service;
		}
	}
}

