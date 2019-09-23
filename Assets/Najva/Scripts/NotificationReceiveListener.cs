using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace najva {
	
	public class NotificationReceiveListener : AndroidJavaProxy
	{
		public NotificationReceiveListener() : base("com.najva.unityplugin.callback.NotificationReceivedListener") { }
		
		void onNotificationReceived(AndroidJavaObject map)
		{
			Debug.Log("notification received");
			Debug.Log(map);
		}
    
	}

}
