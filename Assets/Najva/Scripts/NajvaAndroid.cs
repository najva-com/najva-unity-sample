
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

      mNajva = new AndroidJavaObject("com.najva.unityplugin.NajvaUnity");

      mNajva.CallStatic("initialize",activity);
      
      //SetInFocusDisplaying(displayOption);
	  mNajva.CallStatic("setNotificationReceivedListener",new NotificationReceiveCallback());
	  mNajva.CallStatic("setNotificationClickedListener",new NotificationClickCallback());
	  mNajva.CallStatic("handleUser",new UserCallback());

   }

    public void SetJsonCallback(JsonCallback callback){
        mNajva.CallStatic("handleJson",callback);
    }

   public void SetUserHandler(UserCallback callback)
   {
      mNajva.CallStatic("handleUser",callback);
   }

    public string GetSubscribedToken(){
        return mNajva.CallStatic<String>("getSubscribedToken");
    }
	
	public void SetNotificationReceiveCallback(NotificationReceiveCallback callback){
		mNajva.CallStatic("setNotificationReceivedListener",callback);
	}
	
	public void SetNotificationClickCallback(NotificationClickCallback callback){
		mNajva.CallStatic("setNotificationClickedListener",callback);
	}
}
}
#endif