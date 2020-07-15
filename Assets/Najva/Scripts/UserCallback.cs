using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace najva
{
    public class UserCallback : AndroidJavaProxy
    {
        public UserCallback() : base("com.najva.unityplugin.callback.UserCallback") { }

        void onUserSubscribed(string token)
        {
            Debug.Log(token);
        }
    }

    
}
