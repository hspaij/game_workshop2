using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollissionScript : MonoBehaviour
{
    GameObject lightsource;
    GameObject scissors;

    void OnCollisionEnter(Collision col)
    {
	if (col.gameObject.name == "Lightsource") 
	{
		this.lightsource = col.gameObject;
		this.lightsource.GetComponent<LightsourceMovement>().pickedUp = true;
	}

	if (col.gameObject.name == "Scissors") 
	{
		print("collision124");
		this.scissors = col.gameObject;
		this.scissors.GetComponent<ScissorsMovement>().pickedUp = true;
	}

	if (col.gameObject.name == "LightsourceDestination")
	{
		this.lightsource.GetComponent<LightsourceMovement>().placeLightsource();
	}
    }
}
/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPaint : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision col)
    {
	GameObject[] walls;
        Debug.Log(col.gameObject.name);

	if (col.gameObject.name == "PaintRed") {
            GetComponent<MeshRenderer>().material.color = Color.red;
	    walls = GameObject.FindGameObjectsWithTag("RedWall");
	    foreach(GameObject wall in walls) {
		wall.active = false;
	    }

	    
	    walls = GameObject.FindGameObjectsWithTag("YellowWall");
            foreach(GameObject wall in walls) {
		wall.active = true;
	    }
		
		
	    walls = GameObject.FindGameObjectsWithTag("BlueWall");
            foreach(GameObject wall in walls) {
		wall.active = true;
	    }


	} else if (col.gameObject.name == "PaintBlue") {
Debug.Log(123);
            GetComponent<MeshRenderer>().material.color = Color.blue;
	    walls = GameObject.FindGameObjectsWithTag("RedWall");
	    foreach(GameObject wall in walls) {
		wall.active = true;
	    }

	    
	    walls = GameObject.FindGameObjectsWithTag("YellowWall");
            foreach(GameObject wall in walls) {
		wall.active = true;
	    }
		
		
	    walls = GameObject.FindGameObjectsWithTag("BlueWall");
            foreach(GameObject wall in walls) {
		wall.active = false;
	    }
	} else if (col.gameObject.name == "PaintYellow") {
            GetComponent<MeshRenderer>().material.color = Color.yellow;
	    walls = GameObject.FindGameObjectsWithTag("RedWall");
	    foreach(GameObject wall in walls) {
		wall.active = true;
	    }

	    
	    walls = GameObject.FindGameObjectsWithTag("YellowWall");
            foreach(GameObject wall in walls) {
		wall.active = false;
	    }
		
		
	    walls = GameObject.FindGameObjectsWithTag("BlueWall");
            foreach(GameObject wall in walls) {
		wall.active = true;
	    }
	}
    }
}
*/