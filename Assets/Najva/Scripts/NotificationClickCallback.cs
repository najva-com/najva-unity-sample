using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace najva
{
    public class NotificationClickCallback : AndroidJavaProxy
    {
        public NotificationClickCallback() : base("com.najva.unityplugin.callback.NotificationClickListener") { }

        void onNotificationClicked(AndroidJavaObject map)
        {
            Debug.Log("notification clicked");
        }
    }

    
}