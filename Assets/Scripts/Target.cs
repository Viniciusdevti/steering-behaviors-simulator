using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {

	public int speed;
	public Vector3 instantVelocity;
	public Vector3 velocity;

	void Start () {
		this.velocity = Vector3.zero;
		this.instantVelocity = Vector3.zero;
	}


	void Update () {

		Vector3 pos = transform.position;

		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");

		transform.Translate(h * speed * Time.deltaTime, v * speed * Time.deltaTime, 0, Space.World);

		if(transform.position.x > 9.25f)
		{
			transform.position = new Vector2(-9.25f, transform.position.y);
		}

		if (transform.position.x < -9.25f)
		{
			transform.position = new Vector2(9.25f, transform.position.y);
		}

		if (transform.position.y > 5)
		{
			transform.position = new Vector2(transform.position.x, -5);
		}

		if (transform.position.y < -5)
		{
			transform.position = new Vector2(transform.position.x, 5);
		}

		instantVelocity = transform.position - pos;

		Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		float angle = Mathf.Atan2(mousePosition.y - transform.position.y, mousePosition.x - transform.position.x) * Mathf.Rad2Deg;

		transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
	}
}
