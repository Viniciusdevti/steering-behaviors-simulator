using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciadorDeBotoes : MonoBehaviour {

	public void carregarSceneEscolhaComportamento()
	{
		SceneManager.LoadScene("EscolhaComportamento");
	}

	public void carregarSceneTutorial()
	{
		SceneManager.LoadScene("Tutorial");
	}

	public void Sair()
	{
		Application.Quit();
	}

}
