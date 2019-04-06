
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
	public Transform[] spawnPoints;
	public GameObject blockPrefab;
	public float timeToSpawn=2f;
	public float rate =10f;
	public Vector3 offset;
	public int k;

    // Start is called before the first frame update
    void Start()
    {

    	

   
    
        
    }

    // Update is called once per frame
    void Update()
    {
    	
    		
        if((Time.time>=timeToSpawn)){
    		creationSpawn();
    		timeToSpawn=Time.time+rate;
    	}

    	
    	

    	

    }

    void creationSpawn(){

    	int j=0;
    	for(int i=0;i<spawnPoints.Length;i++){
    		int flag = Random.Range(0,3);
    		if(flag!=1&&j<k){
    			Instantiate(blockPrefab,spawnPoints[i].position,Quaternion.identity);
    			j++;
    		}

    		spawnPoints[i].position=spawnPoints[i].position+offset;
    	}

    }


}
