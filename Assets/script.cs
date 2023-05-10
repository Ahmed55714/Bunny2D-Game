using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 
public class script : MonoBehaviour
{

    // c h a n g e  s p e e d  i n  u n i t y
    [SerializeField]
    float speed = 200;


     // c h a n g e  j u m p  i n  u n i t y
    [SerializeField]
    float jump = 10f;

    public TextMeshPro scoreText;
    public TextMeshPro winLose;
    public int score = 0;
  
    
    SpriteRenderer mySprite;
    Rigidbody2D rb;
    Animator anim;
    bool isJump;

   
    void Start()
    {
     scoreText.text = score.ToString() + " POINTS";
    
    isJump = false;

    mySprite = GetComponent<SpriteRenderer>();
    rb = GetComponent<Rigidbody2D>();
    anim =  GetComponent<Animator>();
        
    }


    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
       // transform.Translate(new Vector3(-1*speed, 0));
        mySprite.flipX = true;
    } 
    else if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.B)) {
       // transform.Translate(new Vector3(speed, 0));
        mySprite.flipX = false;
    }



    // j u m p

     if(Input.GetButtonDown("Jump") && isJump == false) {
         rb.velocity = new Vector2(0, jump);
         isJump = true; 
     }

      if(Mathf.Abs(rb.velocity.y) < 0.01f) {
          isJump = false;
      }
     anim.SetFloat("Speed", Mathf.Abs(rb.velocity.x));

    // W I N S C R E E N

     if(score >= 6) {
        winLose.text = "You Win";
        Time.timeScale = 0f;
     }


    }

     // t a k e c o i n

    private void OnTriggerEnter2D(Collider2D collision) {
 
        if(collision.CompareTag("Carrot"))
        {
            score += 1;
           // Debug.Log(score);
            Destroy(collision.gameObject);
            scoreText.text = score.ToString() + " POINTS";
        }
    }

    void FixedUpdate() {
        
         rb.velocity = new Vector2(speed* Input.GetAxis("Horizontal")* Time.deltaTime, rb.velocity.y);
        
    }

   
}

