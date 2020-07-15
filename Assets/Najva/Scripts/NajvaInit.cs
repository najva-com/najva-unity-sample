using System.Collections;
using UnityEngine;
using najva;
public class NajvaInit : MonoBehaviour
{
	IEnumerator Start () 
	{
		yield return new WaitForSecondsRealtime(5);
		INIT();
		yield return null;
	}	
	void INIT()
	{	
		//Edit Below line and fill it using data from your najva panel
		Najva.init();
		DontDestroyOnLoad(this);
	}

	public void onMessageReceived(string json)
	{
		Debug.Log(json);
	}
	
	public void najvaUserSubscribed(string token)
	{
		Debug.Log(token);
	}



}
