package md54177f1c13d978bcf7745d0240e97d8eb;


public class CustomLabelRenderer
	extends md51558244f76c53b6aeda52c8a337f2c37.LabelRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("XamarinAwesome.Droid.Renderers.CustomLabelRenderer, XamarinAwesome.Android", CustomLabelRenderer.class, __md_methods);
	}


	public CustomLabelRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == CustomLabelRenderer.class)
			mono.android.TypeManager.Activate ("XamarinAwesome.Droid.Renderers.CustomLabelRenderer, XamarinAwesome.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public CustomLabelRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == CustomLabelRenderer.class)
			mono.android.TypeManager.Activate ("XamarinAwesome.Droid.Renderers.CustomLabelRenderer, XamarinAwesome.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public CustomLabelRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == CustomLabelRenderer.class)
			mono.android.TypeManager.Activate ("XamarinAwesome.Droid.Renderers.CustomLabelRenderer, XamarinAwesome.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
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
