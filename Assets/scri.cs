using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scri : MonoBehaviour {
	public GameObject Circle;
	public float speedX;
	public float speedY;
	public float score;
	public float periodlength;
	public Text GameStatus;
	public Text Score;
	
	// Use this for initialization
	void Start () {
		GameStatus.text = "";
		score = 0;
		periodlength = 1;
		Score.text = "Score: "+score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	Vector3 position = this.transform.position;
		if(position.x >= 18){
			position.x = -2;
		}
		if (Input.GetKeyDown("space"))
            {
    			if(position.y <= 7 && position.y >= -2){
				position.y++;
    			this.transform.position = position;
				}
			}
			position.x += speedX;
    		this.transform.position = position;
			score = Mathf.Floor(Time.time * periodlength);
			Score.text = "Score: " + score.ToString();
	}
	
	void OnTriggerEnter(Collider other) {
		if(other.tag == "wall") {
		 Destroy(Circle);
		  GameStatus.text = "You lost";
		}
	}
}
