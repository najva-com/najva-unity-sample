
#if UNITY_ANDROID
using UnityEngine;
using System.Collections.Generic;
using System;

namespace najva
{
public class NajvaAndroid {
   private static AndroidJavaObject mNajva = null;

   public NajvaAndroid() {
      AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
      AndroidJavaObject activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
	  Debug.Log("new object created");
      mNajva = new AndroidJavaObject("com.najva.unityplugin.NajvaUnity");

      mNajva.CallStatic("initialize",activity);
   }

    public void SetJsonCallback(JsonCallback callback){
        mNajva.CallStatic("handleJson",callback);
    }

    public void SetUserHandler(UserCallback callback)
    {
      mNajva.CallStatic("handleUser",callback);
    }

    public string GetSubscribedToken(){
        AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
        
        return mNajva.CallStatic<String>("getSubscribedToken",activity);
    }
	public void SetNotificationReceivedListener(NotificationReceiveListener listener)
	{
		mNajva.CallStatic("setNotificationReceivedListener",listener);
	}
	
	public void SetNotificationClickListener(NotificationClickListener listener)
	{
		mNajva.CallStatic("setNotificationClickedListener",listener);
	}
}
}
#endif