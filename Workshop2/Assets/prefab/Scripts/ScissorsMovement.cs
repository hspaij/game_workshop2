using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScissorsMovement : MonoBehaviour
{
    public bool pickedUp = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         GameObject player = GameObject.FindWithTag("Player");
	 if(this.pickedUp == true) {
		transform.position = new Vector3(
			player.transform.position.x, 
			player.transform.position.y + 1,
			player.transform.position.z);
	  }
    }

    public void useScissors() {
	this.pickedUp = false;
	GameObject finish = GameObject.FindWithTag("Finish");
	transform.position = new Vector3(
		finish.transform.position.x - 1, 
		finish.transform.position.y,
		finish.transform.position.z);
    }
}
