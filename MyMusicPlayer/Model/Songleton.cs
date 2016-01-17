using System.Collections.Generic;

namespace MyMusicPlayer
{	
	public class Songleton
	{
		static Songleton instance;

		public List<Song> AllSongs { get; set; }

		public static Songleton Instance
		{
			get 
			{
				if (instance == null)
				{
					instance = new Songleton();
				}
				return instance;
			}
		}

		public Song this[int i]
		{
			get { return AllSongs[i]; }
			set { AllSongs[i] = value; }
		}
	}
}