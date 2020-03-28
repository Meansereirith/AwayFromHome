using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueMono : MonoBehaviour
{


    private IEnumerator coroutine;
	private GameObject dialogue;
	private TextMeshProUGUI textdialogue; 

	[SerializeField]
	private float waititme;
    string sentence = "Jack was having breakfast with his wife and his 10 years old son, Ben. Although Ben was not the tallest amoung his neighbor, he is pretty smart and frequently took first place in school.";
    // Use this for initialization
    void Start()
    {
        Dialogue.getinstance().set_storysentences(sentence);
        coroutine = coroutine_dialogue(waititme);
		dialogue = GameObject.Find("dialogue");
		textdialogue = dialogue.transform.GetComponent<TextMeshProUGUI>();
        StartCoroutine(coroutine);


    }



    private IEnumerator coroutine_dialogue(float waittime)
    {

        while (true)
        {
            for (int i = 0; i < Dialogue.getinstance().get_storysentences().Count; ++i)
            {
                int j = 0;
                while (Dialogue.getinstance().get_storysentences()[i].Length > j)
                {	
					textdialogue.text = textdialogue.text + Dialogue.getinstance().get_storysentences()[i][j];
                    j++;
                    yield return new WaitForSeconds(waittime);
                }

            }

			break;



        }
    }
}
