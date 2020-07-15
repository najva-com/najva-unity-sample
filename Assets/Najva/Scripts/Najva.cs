using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace najva
{
	public class Najva : MonoBehaviour
	{

		private static NajvaAndroid mnajva;
		public static void init()
		{
			mnajva = new NajvaAndroid();
		}

		public static void SetUserHandler(UserCallback callback)
		{
			mnajva.SetUserHandler(callback);
		}

        public static void SetJsonHandler(JsonCallback callback)
        {
            mnajva.SetJsonCallback(callback);
        }

        public static string GetSubscribedToken()
        {
            return mnajva.GetSubscribedToken();
        }

}


}