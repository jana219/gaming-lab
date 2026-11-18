using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    public AudioClip coin1;
    public AudioClip coin2;

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
           PlayerStatus.score++;
           AudioManager.Instance.PlayRandomSFX(coin1, coin2);
           Debug.Log("Score: " + PlayerStatus.score);
           Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
