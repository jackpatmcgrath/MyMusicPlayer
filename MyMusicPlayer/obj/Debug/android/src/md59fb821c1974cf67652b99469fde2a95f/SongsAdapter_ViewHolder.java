package md59fb821c1974cf67652b99469fde2a95f;


public class SongsAdapter_ViewHolder
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MyMusicPlayer.SongsAdapter+ViewHolder, MyMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", SongsAdapter_ViewHolder.class, __md_methods);
	}


	public SongsAdapter_ViewHolder () throws java.lang.Throwable
	{
		super ();
		if (getClass () == SongsAdapter_ViewHolder.class)
			mono.android.TypeManager.Activate ("MyMusicPlayer.SongsAdapter+ViewHolder, MyMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public SongsAdapter_ViewHolder (android.view.View p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == SongsAdapter_ViewHolder.class)
			mono.android.TypeManager.Activate ("MyMusicPlayer.SongsAdapter+ViewHolder, MyMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Views.View, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
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
