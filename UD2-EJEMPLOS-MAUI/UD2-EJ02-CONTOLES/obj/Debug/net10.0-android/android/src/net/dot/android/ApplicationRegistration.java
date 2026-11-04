package net.dot.android;

public class ApplicationRegistration {

	public static android.content.Context Context;

	public static void registerApplications ()
	{
		// Application and Instrumentation ACWs must be registered first.
		mono.android.Runtime.register ("UD2_EJ02_CONTOLES.MainApplication, UD2-EJ02-CONTOLES, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", crc64c0c7d60c9f66426e.MainApplication.class, crc64c0c7d60c9f66426e.MainApplication.__md_methods);
		mono.android.Runtime.register ("Microsoft.Maui.MauiApplication, Microsoft.Maui, Version=10.0.0.0, Culture=neutral, PublicKeyToken=null", crc6488302ad6e9e4df1a.MauiApplication.class, crc6488302ad6e9e4df1a.MauiApplication.__md_methods);
		
	}
}
