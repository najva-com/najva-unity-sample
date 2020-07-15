using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace najva
{
    public class JsonCallback : AndroidJavaProxy
    {
        public JsonCallback() : base("com.najva.unityplugin.callback.JsonCallback") { }

        void onHandleJsonData(string json)
        {

        }

    }
}
