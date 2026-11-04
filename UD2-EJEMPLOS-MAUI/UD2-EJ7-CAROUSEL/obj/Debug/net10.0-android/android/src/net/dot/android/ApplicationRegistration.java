package net.dot.android;

public class ApplicationRegistration {

	public static android.content.Context Context;

	public static void registerApplications ()
	{
		// Application and Instrumentation ACWs must be registered first.
		mono.android.Runtime.register ("UD2_EJ7_CAROUSEL.MainApplication, UD2-EJ7-CAROUSEL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", crc6493250a7cd19892f4.MainApplication.class, crc6493250a7cd19892f4.MainApplication.__md_methods);
		mono.android.Runtime.register ("Microsoft.Maui.MauiApplication, Microsoft.Maui, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", crc6488302ad6e9e4df1a.MauiApplication.class, crc6488302ad6e9e4df1a.MauiApplication.__md_methods);
		
	}
}
