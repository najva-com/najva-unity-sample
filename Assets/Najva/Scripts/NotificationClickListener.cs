using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace najva{
	
	public class NotificationClickListener : AndroidJavaProxy
	{
		public NotificationClickListener() : base("com.najva.unityplugin.callback.NotificationClickListener") { }

        void onNotificationClicked(AndroidJavaObject map)
        {
			 Debug.Log("notification clicked");
			 Debug.Log(map);
        }
	}
}
