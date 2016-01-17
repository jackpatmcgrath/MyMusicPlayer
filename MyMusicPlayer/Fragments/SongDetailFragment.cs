using Com.Lilarcor.Cheeseknife;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using Android.Content;
using Square.Picasso;

namespace MyMusicPlayer
{
	public class SongDetailFragment : Fragment
	{
		[InjectView(Resource.Id.album_art_detail)] ImageView albumArt;
		[InjectView(Resource.Id.song_title_detail)] TextView songName;
		[InjectView(Resource.Id.artist_name_detail)] TextView artistName;

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			View view = inflater.Inflate (Resource.Layout.SongDetails, container, false);

			Cheeseknife.Inject (this, view);
			Bundle bundle = Arguments;
			if (bundle != null){
				int pos = bundle.GetInt(MainActivity.SONG_INDEX_KEY);

				var songCover = Android.Net.Uri.Parse ("content://media/external/audio/albumart");
				var songAlbumArtUri = ContentUris.WithAppendedId (songCover, Songleton.Instance[pos].AlbumId);
				// CHANGE TO ACCOUNT FOR ERRORS AND NO ALBUM ART
				Picasso.With (Activity).Load (songAlbumArtUri).Into (albumArt);

				songName.Text = Songleton.Instance[pos].Title;
				artistName.Text = Songleton.Instance[pos].Artist;
			}

			return view;
		}

		public override void OnDestroyView() {
			base.OnDestroyView();
			Cheeseknife.Reset(this);
		}
	}
}

