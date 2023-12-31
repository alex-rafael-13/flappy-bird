using UnityEngine;

public class Player : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    private int spriteIndex;

    private Vector3 direction;
    public float gravity = -9.8f;
    public float strength = 5f;

    //Unity function that initializes game objects
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    //Unity function that gets called right when game starts
    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
    }

    //Resetting position and movement of the previous run
    private void OnEnable()
    {
        Vector3 position = transform.position;
        position.y = 0f;
        transform.position = position;
        direction = Vector3.zero;
    }

    //Unity function that gets called every frame, good for changing calculations and inputs
    private void Update() //Inputs
    // Space bar or left click flaps the bird
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){
            direction = Vector3.up * strength;
        }
        //Touch screen inputs
        if (Input.touchCount > 0){ //Checks if the screen got touched at least once
            Touch touch = Input.GetTouch(0); //Gets first touch, disregarding the others

            if(touch.phase == TouchPhase.Began){ //Checks if touch just began
                direction = Vector3.up * strength;
            }
        }

        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime; //Framerate independent
    }

    //Looks through player sprite for animation
    private void AnimateSprite()
    {
        spriteIndex ++;

        if (spriteIndex >= sprites.Length){
            spriteIndex = 0;
        }

        spriteRenderer.sprite = sprites[spriteIndex];
    }

    //Triggers for game state
    private void OnTriggerEnter2D(Collider2D other){

        if(other.gameObject.tag == "Obstacle"){
            //Not the best funct to use since its costly on performance but okay for this example
            FindObjectOfType<GameManager>().GameOver();
        }

        if(other.gameObject.tag == "Scoring"){
            //Not the best funct to use since its costly on performance but okay for this example
            FindObjectOfType<GameManager>().IncreaseScore();
        }
    }
}
