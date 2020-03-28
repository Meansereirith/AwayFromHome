using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class cutscenescripit : MonoBehaviour
{


    private GameObject panel;
    private GameObject dialogue;
    private TextMeshProUGUI textdialogue;
    private IEnumerator coroutine;
    string sentence = "Jack was having breakfast with his wife and his 10 years old son, Ben. Although Ben was not the tallest amoung his neighbor, he is pretty smart and frequently took first place in school.";
    void Start()
    {
        panel = GameObject.Find("Canvas").transform.GetChild(0).gameObject;
     //   Dialogue.getinstance().set_storysentences(sentence);
	 	Dialogue.getinstance().setstory(Sentence.getinstance().get_sentences_list());
	
        coroutine = coroutine_dialogue(0.02f);
        dialogue = GameObject.Find("dialogue");
        textdialogue = dialogue.transform.GetComponent<TextMeshProUGUI>();
    }
    // Use this for initialization

    public void aftercutscene101end()
    {
        panel.SetActive(true);

        StartCoroutine(coroutine);

    }

	public void aftercutscene102end(){
	
		textdialogue.text = "";
		 coroutine = coroutine_dialogue(0.02f);
		StartCoroutine(coroutine);
	}

    // private IEnumerator coroutine_dialogue(float waittime)
    // {

    //     while (true)
    //     {
    //         for (int i = 0; i < Dialogue.getinstance().get_storysentences().Count; ++i)
    //         {
    //             int j = 0;
    //             while (Dialogue.getinstance().get_storysentences()[i].Length > j)
    //             {
    //                 textdialogue.text = textdialogue.text + Dialogue.getinstance().get_storysentences()[i][j];
    //                 j++;
    //                 yield return new WaitForSeconds(waittime);
    //             }

    //         }

    //         break;



    //     }
    // }


    private IEnumerator coroutine_dialogue(float waittime)
    {

        while (true)
        {

            int j = 0;
            while (Dialogue.getinstance().get_storysentences()[Dialogue.getinstance().get_sentenceindex()].Length > j)
            {
				
                textdialogue.text = textdialogue.text + Dialogue.getinstance().get_storysentences()[Dialogue.getinstance().get_sentenceindex()][j];
                j++;
                yield return new WaitForSeconds(waittime);
            }


			Dialogue.getinstance().increment_sentenceindex();
            break;



        }
    }


}
