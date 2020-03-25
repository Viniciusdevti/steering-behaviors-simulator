using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciadorBotesEscolhaComp : MonoBehaviour {
    
	public void comportamentoSeek()
	{
		SceneManager.LoadScene("Seek");
	}

    public void ExplicacaoSeek()
    {
        SceneManager.LoadScene("ExplicaçãoSeek");
    }

    public void ExplicacacaoSeek2()
    {
        SceneManager.LoadScene("ExplicaçãoSeek2");
    }


    public void comportamentoFlee()
	{
		SceneManager.LoadScene("Flee");
	}

    public void ExplicacacaoFlee()
    {
        SceneManager.LoadScene("ExplicaçãoFlee");
    }
        public void ExplicacacaoFlee2()
    {
        SceneManager.LoadScene("ExplicaçãoFlee2");
    }

    public void voltarMenu()
	{
		SceneManager.LoadScene("Menu");
	}

    public void Comportamentos()
    {
        SceneManager.LoadScene("EscolhaComportamento");
    }

}
