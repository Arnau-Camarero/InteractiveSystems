using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	Color[] colors = new Color[3];
     
     void Start()
     {
         colors[0] = Color.cyan;
         colors[1] = Color.red;
         colors[2] = Color.green;
		 gameObject.GetComponent<Renderer>().material.color = colors[Random.Range(0, colors.Length)];
	 }

	// Before rendering each frame..
	void Update () 
	{
		// Rotate the game object that this script is attached to by 15 in the X axis,
		// 30 in the Y axis and 45 in the Z axis, multiplied by deltaTime in order to make it per second
		// rather than per frame.
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}
}	