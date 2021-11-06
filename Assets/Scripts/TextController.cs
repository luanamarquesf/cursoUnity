using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public TextMesh pontuacao;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pontuacao.text = "Pontuacao " + EnemyCounter.inimigosMortos.ToString();
        if(EnemyCounter.victory){
            pontuacao.text = "Parabéns! Você venceu :D. Pressione Q para sair.";
            if (Input.GetKeyDown(KeyCode.Q)){
                Application.Quit();
            }
        }
    }
}

