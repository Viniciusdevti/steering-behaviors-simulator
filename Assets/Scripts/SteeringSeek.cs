using UnityEngine;
using System.Collections;

public class SteeringSeek : MonoBehaviour {

	public Transform target;

	public float maxSpeed;

	private LineRenderer line;

	private Vector3 direcao;
	public Vector3 Direcao
	{
		get { return this.direcao; }
	}
	private Vector3 direcaoNormalizada;
	public Vector3 DirecaoNormalizada
	{
		get { return this.direcaoNormalizada; }
	}
	private Vector3 velocity;
	public Vector3 Velocity
	{
		get { return this.velocity; }
	}

	private bool modoDebug;
	public bool ModoDebug {
		get { return modoDebug; }
	}


	void Start(){
		line = this.GetComponent<LineRenderer>();
		line.SetWidth(0.05F, 0.05F);
		line.SetVertexCount(2);
	}
	

	void Update () {

		direcao = target.position - transform.position;

		direcaoNormalizada = direcao.normalized;
		velocity = direcaoNormalizada * maxSpeed * Time.deltaTime;
		this.transform.position += velocity;

		if (transform.position.x > 9.25f)
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

		float angle = Mathf.Atan2(target.position.y - transform.position.y, target.position.x - transform.position.x) * Mathf.Rad2Deg;

		transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

		if (modoDebug) {
			line.positionCount = 2;
			line.SetPosition(0, target.position);
			line.SetPosition(1, transform.position);
			maxSpeed = 0.1f;
		}
		if (!modoDebug)
		{
			line.positionCount = 0;
			maxSpeed = 3;
		}

		if (Input.GetKeyDown(KeyCode.Z))
		{
			modoDebug = !modoDebug;
		}
	}
}
