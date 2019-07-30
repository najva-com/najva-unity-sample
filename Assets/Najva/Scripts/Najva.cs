using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace najva
{


	public class Najva : MonoBehaviour
	{

		private static NajvaAndroid mnajva;
		public static void init(GameObject gameObject, int campaingnID, int websiteId, string apiKey, bool location)
		{
			mnajva = new NajvaAndroid(gameObject.name, campaingnID, websiteId, apiKey, location);
		}

		public static void SetUserHandler(UserCallback callback)
		{
			mnajva.SetUserHandler(callback);
		}

        public static void SetJsonHandler(JsonCallback callback)
        {
            mnajva.SetJsonCallback(callback);
        }

}


}