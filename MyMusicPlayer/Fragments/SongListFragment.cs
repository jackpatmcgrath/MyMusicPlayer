using Android.App;
using Android.OS;
using Android.Widget;
using Android.Views;
using Android.Util;

namespace MyMusicPlayer
{
	public class SongListFragment : ListFragment
	{
		public override void OnActivityCreated (Bundle savedInstanceState)
		{
			base.OnActivityCreated (savedInstanceState);
			ListAdapter = new SongsAdapter (Activity);
		}

		public override void OnListItemClick(ListView l, View v, int position, long id)
		{
			if (MainActivity.musicSrv != null) {
				MainActivity.musicSrv.songPos = position;
				MainActivity.musicSrv.PlaySong ();

				SongDetailFragment songDetailFragment = new SongDetailFragment ();
				Bundle bundle = new Bundle ();
				bundle.PutInt(MainActivity.SONG_INDEX_KEY, position);
				songDetailFragment.Arguments = bundle;

				var trans = FragmentManager.BeginTransaction();
				trans.Replace(Resource.Id.fragment_container, songDetailFragment);

				trans.AddToBackStack(null);
				trans.Commit();
				Activity.ActionBar.SetDisplayHomeAsUpEnabled(true);

				//MusicControlFragment.controller.Show (0);
			} else {
				Log.Error (MainActivity.MUSIC_ERR_TAG, "Music service not started.");
			}
		}
	}
}

