using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    private Movement mov;
    [SerializeField]
    private AudioSource aud;
    public AudioClip clip;
	// Use this for initialization
	void Start () {
        aud = GetComponent<AudioSource>();
        mov = GameObject.Find("Main Camera").GetComponent<Movement>();
        if(mov == null)
        {
            Debug.Log("It is Null");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        mov.addScore();
        aud.PlayOneShot(clip);

    }
}
