using System;
using System.Collections.Generic;
using Android.Provider;
using Android.Content;
using Android.Database;
using Android.App;

namespace MyMusicPlayer
{
	public static class MusicRetrieval
	{
		public static List<Song> LoadSongs (Activity context)
		{
			var uri = MediaStore.Audio.Media.ExternalContentUri;
			String selection = MediaStore.Audio.Media.InterfaceConsts.IsMusic + " != 0";
			string[] projection = {
				MediaStore.Audio.Media.InterfaceConsts.Id,
				MediaStore.Audio.Albums.InterfaceConsts.AlbumId,
				MediaStore.Audio.Media.InterfaceConsts.Title,
				MediaStore.Audio.Media.InterfaceConsts.Artist,
			};

			var loader = new CursorLoader (context, uri, projection, selection, null, null);
			var cursor = (ICursor)loader.LoadInBackground ();

			List<Song> songs = new List<Song> ();
			if (cursor.MoveToFirst ()) {
				do {
					songs.Add (new Song (
						cursor.GetLong (cursor.GetColumnIndex (projection [0])),
						cursor.GetLong (cursor.GetColumnIndex (projection [1])),
						cursor.GetString (cursor.GetColumnIndex (projection [2])),
						cursor.GetString (cursor.GetColumnIndex (projection [3]))
					));
				} while (cursor.MoveToNext ());
			}
			return songs;
		}
	}
}

