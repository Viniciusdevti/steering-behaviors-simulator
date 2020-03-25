using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GerenciadorTextoFlee : MonoBehaviour {

	public SteeringFlee flee;
	public Target player;
	public Image imgDirecao, imgVelocidadeDesejada;
	public Text textDirecao, textVelocidadeDesejada;
	public Text textPosXAgente, textPosYAgente;
	public Text textPosXJogador, textPosYJogador;
	public Text textVetorDirecaoN, textVelocidadeDesejadaX, textVelocidadeDesejadaY, textVetorDirecao;
	public Image imgEixoX, imgEixoY;

	void Update()
	{
		if (flee.ModoDebug)
		{
			imgDirecao.gameObject.SetActive(true);
			imgVelocidadeDesejada.gameObject.SetActive(true);
			textVelocidadeDesejada.gameObject.SetActive(true);
			textDirecao.gameObject.SetActive(true);
			textPosXAgente.gameObject.SetActive(true);
			textPosYAgente.gameObject.SetActive(true);
			textPosXJogador.gameObject.SetActive(true);
			textPosYJogador.gameObject.SetActive(true);
			textVetorDirecaoN.gameObject.SetActive(true);
			textVelocidadeDesejadaX.gameObject.SetActive(true);
			textVelocidadeDesejadaY.gameObject.SetActive(true);
			textVetorDirecao.gameObject.SetActive(true);
			imgEixoX.gameObject.SetActive(true);
			imgEixoY.gameObject.SetActive(true);
		}
		else
		{
			imgDirecao.gameObject.SetActive(false);
			imgVelocidadeDesejada.gameObject.SetActive(false);
			textVelocidadeDesejada.gameObject.SetActive(false);
			textDirecao.gameObject.SetActive(false);
			textPosXAgente.gameObject.SetActive(false);
			textPosYAgente.gameObject.SetActive(false);
			textPosXJogador.gameObject.SetActive(false);
			textPosYJogador.gameObject.SetActive(false);
			textVetorDirecaoN.gameObject.SetActive(false);
			textVelocidadeDesejadaX.gameObject.SetActive(false);
			textVelocidadeDesejadaY.gameObject.SetActive(false);
			textVetorDirecao.gameObject.SetActive(false);
			imgEixoX.gameObject.SetActive(false);
			imgEixoY.gameObject.SetActive(false);
		}

		textPosXAgente.text = "Pos X - Agente:" + flee.transform.position.x.ToString();
		textPosYAgente.text = "Pos Y - Agente:" + flee.transform.position.y.ToString();
		textPosXJogador.text = "Pos X - Jogador:" + player.transform.position.x.ToString();
		textPosYJogador.text = "Pos Y - Jogador:" + player.transform.position.y.ToString();
		Vector2 newDirectionN = flee.DirecaoNormalizada;
		textVetorDirecaoN.text = "Vetor Direção Normalizada: " + newDirectionN.ToString();
		Vector2 newDirection = flee.Direcao;
		textVetorDirecao.text = "Vetor Direção: " + newDirection.ToString();
		textVelocidadeDesejadaX.text = "Velocidade Desejada X: " + flee.Velocity.x.ToString();
		textVelocidadeDesejadaY.text = "Velocidade Desejada Y: " + flee.Velocity.y.ToString();
	}
}
