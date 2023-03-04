using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {



	public Text Name;
	public Text Dialogue;
	private Queue<string> Sentences;
	public Animator anim;
    DialogueTrigger dt;
	


	void Start () {

		Sentences = new Queue<string>() ;
		dt = FindObjectOfType<DialogueTrigger>() ;
	
	}

	public void StartDialogue(Dialogue dialogue)
	{
		
		anim.SetBool("IsOpen", true);
		Name.text = dialogue.name;
		Sentences.Clear();
		foreach (string sentence in dialogue.Sentences)
		{
			Sentences.Enqueue(sentence);
		}
		DisplayNextSentence();
		
		
	}
	public void DisplayNextSentence ()
	{
		if ( Sentences.Count == 0 )
		{
			EndDialogue();
			return;
		}
		string sentence = Sentences.Dequeue();
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence));
	}

	IEnumerator TypeSentence (string sentence)
	{
		Dialogue.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			Dialogue.text += letter;
			yield return null;
		}
	}

	public void EndDialogue()
	{
		
		anim.SetBool("IsOpen", false);
		
		
		
	}
}
