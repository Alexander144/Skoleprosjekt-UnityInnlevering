using UnityEngine;
using System.Collections;

public class Lyd : MonoBehaviour {
	public AudioClip trippel;
	public AudioClip vow;
	public AudioClip smoke;
	public static int trippelGreen;
	public static int blue;
	public static int red;
	public static int green;
	public static int yellow;
	public static int count = 0;
	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		if (blue >= 1 && red >= 1 && green >= 1 && count==0 ) {
			baby ();
			count=count + 1;
		}
		if (blue >= 2 && red >= 2 && green >= 2 && count ==1) {
			wow ();
			count = count + 1;
		}
		if(trippelGreen == 3){
			weed ();
			trippelGreen = 0;
		}
	}
	void baby()
	{
		AudioSource.PlayClipAtPoint(trippel,transform.position);
	}
	void wow()
	{
		AudioSource.PlayClipAtPoint(vow,transform.position);
	}
	void weed()
	{
		AudioSource.PlayClipAtPoint(smoke,transform.position);
	}


}