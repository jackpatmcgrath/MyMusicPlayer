package md59fb821c1974cf67652b99469fde2a95f;


public class MusicControlFragment
	extends android.app.Fragment
	implements
		mono.android.IGCUserPeer,
		android.widget.MediaController.MediaPlayerControl
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreateView:(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroid/view/View;:GetOnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_Handler\n" +
			"n_getAudioSessionId:()I:GetGetAudioSessionIdHandler:Android.Widget.MediaController/IMediaPlayerControlInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_getBufferPercentage:()I:GetGetBufferPercentageHandler:Android.Widget.MediaController/IMediaPlayerControlInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_getCurrentPosition:()I:GetGetCurrentPositionHandler:Android.Widget.MediaController/IMediaPlayerControlInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_getDuration:()I:GetGetDurationHandler:Android.Widget.MediaController/IMediaPlayerControlInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_isPlaying:()Z:GetIsPlayingHandler:Android.Widget.MediaController/IMediaPlayerControlInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_canPause:()Z:GetCanPauseHandler:Android.Widget.MediaController/IMediaPlayerControlInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_canSeekBackward:()Z:GetCanSeekBackwardHandler:Android.Widget.MediaController/IMediaPlayerControlInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_canSeekForward:()Z:GetCanSeekForwardHandler:Android.Widget.MediaController/IMediaPlayerControlInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_pause:()V:GetPauseHandler:Android.Widget.MediaController/IMediaPlayerControlInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_seekTo:(I)V:GetSeekTo_IHandler:Android.Widget.MediaController/IMediaPlayerControlInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_start:()V:GetStartHandler:Android.Widget.MediaController/IMediaPlayerControlInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("MyMusicPlayer.MusicControlFragment, MyMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MusicControlFragment.class, __md_methods);
	}


	public MusicControlFragment () throws java.lang.Throwable
	{
		super ();
		if (getClass () == MusicControlFragment.class)
			mono.android.TypeManager.Activate ("MyMusicPlayer.MusicControlFragment, MyMusicPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public android.view.View onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2)
	{
		return n_onCreateView (p0, p1, p2);
	}

	private native android.view.View n_onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2);


	public int getAudioSessionId ()
	{
		return n_getAudioSessionId ();
	}

	private native int n_getAudioSessionId ();


	public int getBufferPercentage ()
	{
		return n_getBufferPercentage ();
	}

	private native int n_getBufferPercentage ();


	public int getCurrentPosition ()
	{
		return n_getCurrentPosition ();
	}

	private native int n_getCurrentPosition ();


	public int getDuration ()
	{
		return n_getDuration ();
	}

	private native int n_getDuration ();


	public boolean isPlaying ()
	{
		return n_isPlaying ();
	}

	private native boolean n_isPlaying ();


	public boolean canPause ()
	{
		return n_canPause ();
	}

	private native boolean n_canPause ();


	public boolean canSeekBackward ()
	{
		return n_canSeekBackward ();
	}

	private native boolean n_canSeekBackward ();


	public boolean canSeekForward ()
	{
		return n_canSeekForward ();
	}

	private native boolean n_canSeekForward ();


	public void pause ()
	{
		n_pause ();
	}

	private native void n_pause ();


	public void seekTo (int p0)
	{
		n_seekTo (p0);
	}

	private native void n_seekTo (int p0);


	public void start ()
	{
		n_start ();
	}

	private native void n_start ();

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
