using System;

namespace MyMusicPlayer
{
	public class Song
	{
		public long Id { get; set; }
		public long AlbumId { get; set; }
		public String Title { get; set; }
		public String Artist { get; set; }

		public Song (long Id, long AlbumId, String Title, String Artist)
		{
			this.Id = Id;
			this.AlbumId = AlbumId;
			this.Title = Title;
			this.Artist = Artist;
		}
	}
}

