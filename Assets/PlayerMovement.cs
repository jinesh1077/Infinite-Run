
using UnityEngine;
using UnityEngine.UI;
using System.Collections;



public class PlayerMovement : MonoBehaviour
{
	public Rigidbody rb; 
	public float force=2000f;
	public float side=40f;
    public float speed=40f;
    public float up=13000f;
    public Text bonusText;
    public bool touch=true;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    	//rb.AddForce(0,0,force*Time.deltaTime);
        rb.velocity = new Vector3(rb.velocity.x , rb.velocity.y, speed);
        if(rb.position.y==1f){
            touch=true;
        }

    	if(Input.GetKey("d")||(Input.GetMouseButtonDown(1))){

    		rb.AddForce(side*Time.deltaTime,0,0,ForceMode.VelocityChange);
    	}

    	if(Input.GetKey("a")||(Input.GetMouseButtonDown(0))){

    		rb.AddForce(-1*side*Time.deltaTime,0,0,ForceMode.VelocityChange);
    	}

    	if(Input.GetKey("b")){
            if(touch==true&&(int.Parse(bonusText.text))!=0){
                bonusText.text=(int.Parse(bonusText.text)-1).ToString("0");
    		  rb.AddForce(0,up*Time.deltaTime,0);
              touch=false;

            }
            
    	}
    	if(rb.position.y<-1f){
    		FindObjectOfType<GameManger>().EndGame();
    	}

        


        
    }
}
