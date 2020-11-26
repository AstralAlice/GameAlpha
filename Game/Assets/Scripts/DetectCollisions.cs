using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public AudioClip Boom;
    public AudioClip Blip;
    private AudioSource PlayerAudio;
    public int hp = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerAudio = GetComponent<AudioSource>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (this.hp == 0){
            Destroy(gameObject);
            Destroy(other.gameObject);
            Debug.Log("Game Over");
            this.PlayerAudio.PlayOneShot(this.Boom, 1.0f);
        }
        if (this.hp >= 1)
        {
            Destroy(other.gameObject);
            this.hp = this.hp - 1;
            this.PlayerAudio.PlayOneShot(this.Boom, 1.0f);
        }
    }
}
