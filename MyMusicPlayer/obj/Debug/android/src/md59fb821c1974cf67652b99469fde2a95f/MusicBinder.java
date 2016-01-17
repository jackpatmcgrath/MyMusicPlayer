package md59fb821c1974cf67652b99469fde2a95f;


public class MusicBinder
	extends android.os.Binder
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MyMusicPlayer.MusicBinder, MyMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MusicBinder.class, __md_methods);
	}


	public MusicBinder () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MusicBinder.class)
			mono.android.TypeManager.Activate ("MyMusicPlayer.MusicBinder, MyMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public MusicBinder (md59fb821c1974cf67652b99469fde2a95f.MusicService p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == MusicBinder.class)
			mono.android.TypeManager.Activate ("MyMusicPlayer.MusicBinder, MyMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "MyMusicPlayer.MusicService, MyMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
