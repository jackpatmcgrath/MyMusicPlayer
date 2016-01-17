package md59fb821c1974cf67652b99469fde2a95f;


public class MusicController
	extends android.widget.MediaController
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_hide:()V:GetHideHandler\n" +
			"n_dispatchKeyEvent:(Landroid/view/KeyEvent;)Z:GetDispatchKeyEvent_Landroid_view_KeyEvent_Handler\n" +
			"";
		mono.android.Runtime.register ("MyMusicPlayer.MusicController, MyMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MusicController.class, __md_methods);
	}


	public MusicController (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == MusicController.class)
			mono.android.TypeManager.Activate ("MyMusicPlayer.MusicController, MyMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public MusicController (android.content.Context p0, android.util.AttributeSet p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == MusicController.class)
			mono.android.TypeManager.Activate ("MyMusicPlayer.MusicController, MyMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public MusicController (android.content.Context p0, boolean p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == MusicController.class)
			mono.android.TypeManager.Activate ("MyMusicPlayer.MusicController, MyMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Boolean, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1 });
	}


	public void hide ()
	{
		n_hide ();
	}

	private native void n_hide ();


	public boolean dispatchKeyEvent (android.view.KeyEvent p0)
	{
		return n_dispatchKeyEvent (p0);
	}

	private native boolean n_dispatchKeyEvent (android.view.KeyEvent p0);

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
