
using UnityEngine;
using UnityEngine.UI;


public class PlayerCollision : MonoBehaviour
{
	public PlayerMovement movement;
	public Text bonusText;
	
	//backgroundColor = Color (0.5, 0.5, 0.5, 1);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collisionInfo){

    	if(collisionInfo.collider.tag=="Obstacle"){
    		movement.enabled=false;
    		
    		FindObjectOfType<GameManger>().EndGame();
    	}

    	if(collisionInfo.collider.tag=="bonus"){
    		
    		Debug.Log("Colllll");
			
    		bonusText.text=(int.Parse(bonusText.text)+1).ToString("0");
    		Destroy(collisionInfo.gameObject);


    	}

    	

    }

}
