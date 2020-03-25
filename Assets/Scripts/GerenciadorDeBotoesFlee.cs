using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciadorDeBotoesFlee : MonoBehaviour {

	public void voltarMenu()
	{
		SceneManager.LoadScene("Menu");
	}
}
