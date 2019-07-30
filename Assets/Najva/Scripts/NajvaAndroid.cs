
#if UNITY_ANDROID
using UnityEngine;
using System.Collections.Generic;
using System;

namespace najva
{
public class NajvaAndroid {
   private static AndroidJavaObject mNajva = null;

   public NajvaAndroid(string gameObjectName, int campaingnID, int websiteId, string apiKey, bool location) {
      AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
      AndroidJavaObject activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");

      mNajva = new AndroidJavaObject("com.najva.unityplugin.NajvaUnity");

      mNajva.CallStatic("initialize",activity,campaingnID,websiteId,apiKey,location);
      
      //SetInFocusDisplaying(displayOption);
   }

    public void SetJsonCallback(JsonCallback callback){
        mNajva.CallStatic("handleJson",callback);
    }

   public void SetUserHandler(UserCallback callback)
   {
      mNajva.CallStatic("handleUser",callback);
   }
}
}
#endif