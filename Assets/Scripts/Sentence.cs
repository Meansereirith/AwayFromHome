using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sentence  {

	// Use this for initialization
	 private static Sentence instance;
	 private List<string> sentences_list = new List<string>();
	 private string sentence1 = "abc";
	 private string sentence2 = "nice";
	 private Sentence(){
		 sentences_list.Add(sentence1);
		 sentences_list.Add(sentence2);
	 }

	 public static Sentence getinstance(){
		 if(instance==null){
			 instance = new Sentence();
		 }
		 return instance;
	 }

	 public List<string> get_sentences_list(){
		 return sentences_list;
	 }

	 




}
