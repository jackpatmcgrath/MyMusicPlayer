using Android.Widget;
using Android.App;
using Android.Views;
using Android.Content;
using System.Collections.Generic;
using Com.Lilarcor.Cheeseknife;
using Square.Picasso;

namespace MyMusicPlayer
{
	public class SongsAdapter : BaseAdapter<Song>
	{
		List<Song> songList;
		Activity context;

		public SongsAdapter (Activity context)
		{
			this.context = context;
			songList = Songleton.Instance.AllSongs;
		}

		public override long GetItemId (int position)
		{
			return songList [position].Id;
		}

		public override Song this [int index] {  
			get { return songList [index]; }
		}

		public override int Count {
			get { return songList.Count; }
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			ViewHolder viewHolder;

			if (convertView == null) {
				convertView = LayoutInflater.From (context).Inflate (Resource.Layout.SongRow, parent, false);
				viewHolder = new ViewHolder (convertView);
				convertView.Tag = viewHolder;
			} else {
				viewHolder = (ViewHolder)convertView.Tag;
			}

			viewHolder.TitleView.Text = songList [position].Title;
			viewHolder.ArtistView.Text = songList [position].Artist;

			var songCover = Android.Net.Uri.Parse ("content://media/external/audio/albumart");
			var songAlbumArtUri = ContentUris.WithAppendedId (songCover, songList [position].AlbumId);
			// CHANGE TO ACCOUNT FOR ERRORS AND NO ALBUM ART
			Picasso.With (context).Load (songAlbumArtUri).Into (viewHolder.AlbumArtView);

			return convertView;
		}

		class ViewHolder : Java.Lang.Object
		{
			[InjectView (Resource.Id.song_title)]
			public TextView TitleView { get; private set; }

			[InjectView (Resource.Id.artist_name)]
			public TextView ArtistView { get; private set; }

			[InjectView (Resource.Id.album_art)]
			public ImageView AlbumArtView { get; private set; }

			public ViewHolder (View view)
			{
				Cheeseknife.Inject (this, view);
			}
		}
	}
}

