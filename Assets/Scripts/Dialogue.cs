using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dialogue 
{

    private static Dialogue instance;

    private List<string> sentences_list = new List<string>();
    // private IEnumerator coroutine;
    // private TextMeshProUGUI textdialogue;
    // private GameObject dialogue;
	private int sentence_index = 0;
	 string sentence = "Jack was having breakfast with his wife and his 10 years old son, Ben. Although Ben was not the tallest amoung his neighbor, he is pretty smart and frequently took first place in school.";
    private Dialogue()
    {
        // Dialogue.getinstance().set_storysentences(sentence);
		// coroutine = coroutine_dialogue(1f);
		// dialogue = GameObject.Find("dialogue");
		// textdialogue = dialogue.transform.GetComponent<TextMeshProUGUI>();
	
		
    }

    public static Dialogue getinstance()
    {
        if (instance == null)
        {
		
            instance = new Dialogue();
        }
        return instance;
    }


    public void set_storysentences(string sentence)
    {
        sentences_list.Add(sentence);
    }

    public void clear_sentences()
    {

        sentences_list.Clear();
    }

    public List<string> get_storysentences()
    {
        return sentences_list;
    }

    public void increment_sentenceindex(){
		sentence_index++;
	}

	public int get_sentenceindex(){
		return sentence_index;
	}

	public void setstory( List<string> sentencesstory){
		sentences_list = sentencesstory;
	}
	
}
