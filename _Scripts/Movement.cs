using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour {
 public Vector3 defaultzombieSize;
 public Vector3 selectedZombieSize;
    
    private GameObject selectedZombie;
    public List<GameObject> zombies;
    private int zombiePosition;
    [SerializeField]
    private Text scoreText;
    private int score = 0;
	// Use this for initialization
	void Start () {
        selectedZombie = zombies[0];
        scoreText.text = "Score: " + score;
        
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GetLeft();
        }
        if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetRight();
        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            Pushup();
        }
		
	}
    void ZombieSize(GameObject zombie)
    {
        selectedZombie.transform.localScale = defaultzombieSize;
        selectedZombie = zombie;
        zombie.transform.localScale = selectedZombieSize;
        
    }

    void GetLeft()
    {
        if (zombiePosition == 0)
        {
            zombiePosition = 3;
            ZombieSize(zombies[3]);
            

        }
        else
        {
            zombiePosition -= 1;
            ZombieSize(zombies[zombiePosition]);
            
        }
       
    }

    void GetRight()
    {
        if(zombiePosition == 3)
        {
            zombiePosition = 0;
            ZombieSize(zombies[0]);
            
        }
        else
        {
            zombiePosition += 1;
            ZombieSize(zombies[zombiePosition]);
            
        }
    }
    void Pushup()
    {
        Rigidbody rb = selectedZombie.GetComponent<Rigidbody>();
        rb.AddForce(0, 0, 10, ForceMode.Impulse);
    }
   public void addScore()
    {
        score = score + 1;
        scoreText.text = "Score: " + score;
        
    }
   
}
