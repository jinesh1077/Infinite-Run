
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManger : MonoBehaviour
{
	public bool GameHasEnd=false;
	public float delay=3f;
	public Text endText;



    public void EndGame()
    {
    	if(GameHasEnd==false){
    		GameHasEnd=true;
    		endText.enabled = true;
    		Debug.Log("GameOver");
    		Invoke("resart",delay);
    		
    	}        
    }

    void resart(){
    	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
