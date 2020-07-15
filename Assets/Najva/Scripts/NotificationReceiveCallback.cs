using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace najva
{
    public class NotificationReceiveCallback : AndroidJavaProxy
    {
        public NotificationReceiveCallback() : base("com.najva.unityplugin.callback.NotificationReceivedListener") { }

        void onNotificationReceived(AndroidJavaObject map)
        {
            Debug.Log("notification received");
        }
    }

    
}