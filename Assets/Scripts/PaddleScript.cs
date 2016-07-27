using UnityEngine;
using System.Collections;

public class PaddleScript : MonoBehaviour {

	[SerializeField]
	bool isPlayerTwo;
	[SerializeField]
	float speed = 0.2f;

	Transform myTransform;
	int direction = 0;
	float previousPositionY;

	// Use this for initialization
	void Start () {
		
		myTransform = transform;
		previousPositionY = myTransform.position.y;

	}
	
	// FixedUpdate is called once per physics tick/frame
	void FixedUpdate () {
		if (isPlayerTwo)
		{
			if (Input.GetKey("o"))
			{
				MoveUp();
			} 
			else if (Input.GetKey ("l")) 
			{
				MoveDown ();
			}
		}
		else 
		{
			if (Input.GetKey ("q")) 
			{
				MoveUp ();
			} 
			else if (Input.GetKey ("a")) 
			{
				MoveDown ();
			}
		}

		if (previousPositionY > myTransform.position.y)
		{
			direction = -1;
		}
		else if (previousPositionY < myTransform.position.y)
		{
			direction = 1;
		}
		else
		{
			direction = 0;
		}
			
	
	}

	void LateUpdate()
	{
		previousPositionY = myTransform.position.y;
	}

	void MoveUp()
	{
		myTransform.position = new Vector2 (myTransform.position.x, myTransform.position.y + speed);
	}

	void MoveDown()
	{
		myTransform.position = new Vector2(myTransform.position.x,myTransform.position.y - speed);
	}

    void OnCollisionExit2D(Collision2D other)
    {
        float adjust = 5 * direction;
        other.rigidbody.velocity = new Vector2(other.rigidbody.velocity.x, other.rigidbody.velocity.y + adjust);        
    }
}
