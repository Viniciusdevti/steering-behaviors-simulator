using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDirecao : MonoBehaviour {

	[SerializeField]
	private SteeringSeek seek;

	[SerializeField]
	private SteeringFlee flee;

	private LineRenderer line;

	[SerializeField]
	private bool ehSeek, ehFlee;


	void Start () {
		line = this.GetComponent<LineRenderer>();
		line.SetWidth(0.05F, 0.05F);
		line.SetVertexCount(2);
	}
	
	
	void Update () {
		if (ehSeek)
		{
			if (seek.ModoDebug)
			{
				line.positionCount = 2;
				line.SetPosition(0, seek.DirecaoNormalizada + transform.position);
			}
		}
		if (ehFlee)
		{
			if (flee.ModoDebug)
			{
				line.positionCount = 2;
				line.SetPosition(0, flee.DirecaoNormalizada + transform.position);
			}
		}
		
		if(seek != null)
		{
			if (seek.ModoDebug)
			{
				line.SetPosition(1, transform.position);
			}
			else
			{
				line.positionCount = 0;
			}
		}

		if (flee != null)
		{
			if (flee.ModoDebug)
			{
				line.SetPosition(1, transform.position);
			}
			else
			{
				line.positionCount = 0;
			}
		}
	}
}
