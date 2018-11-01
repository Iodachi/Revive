using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{

    //Movement
    Vector2 input;
    public float walkSpeed = 7;
    public float runSpeed = 14;
    public float gravity = 15f;
    public float jumpSpeed = 8.0F;
    public float jumpHeight = 10;
    public Vector3 velocity;
    public float velocityY;
    // Lantern Object - Tui
    public GameObject Bow;
    public GameObject Umbrella;
    public GameObject Lantern;
    int flowersPicked = 0;

    //Rotation
    public float turnSmoothTime = 0.2f;
    float turnSmoothVelocity;

    //current level
    string level;

    //Controllers
    Transform camera;
    CharacterController controller;

    public Text task;

    //Animator
    Animator anim;
    bool movingHorizontal = false;
    bool movingVertical = false;

    //Scale
    Vector3 startingScale;
    bool isStartingScale = true;

    //abilities
    bool haveUmbrella = false;
    bool haveBow = false;
    bool haveCandle = false;
    bool haveLantern = false;
    bool haveToy = false;

    //colour changing in according to enemy following
    public int colour = 0;

    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        level = scene.name.Substring(5);

        Bow.SetActive(false);
        Umbrella.SetActive(false);
        Lantern.SetActive(false);

        if(level == "0"){
            UpdateTask();
        }else if(level == "1"){
            obtainBow();
        }else if(level == "2"){
            obtainBow();
            obtainCandle();
            obtainLantern();
        }else if(level == "3"){
            obtainBow();
            obtainCandle();
            obtainLantern();
            obtainUmbrella();
            obtainToy();
        }

        camera = Camera.main.transform;
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        startingScale = transform.localScale;

    }

    void obtainBow(){
        Bow.SetActive(true);
        haveBow = true;
    }

    void obtainCandle(){
        haveCandle = true;
    }

    void obtainUmbrella(){
        Umbrella.SetActive(true);
        haveUmbrella = true;
    }

    void obtainLantern(){
        Lantern.SetActive(true);
        haveLantern = true;
    }

    void obtainToy(){
        haveToy = true;
    }

    //LanterTurnOn + LightTurnOn - Tui
   void OnTriggerEnter(Collider other)
    {
        if(other.tag == "LanternTag"){
            other.gameObject.SetActive(false);
            obtainLantern();
        }

        if(other.tag == "Toy"){
            other.gameObject.SetActive(false);
            obtainToy();
        }

        if(other.tag == "Bow"){
            other.gameObject.SetActive(false);
            obtainBow();
        }

        if(other.tag == "Candle"){
            other.gameObject.SetActive(false);
            obtainCandle();
        }

        if (other.tag == "Pickable")
        {
            other.gameObject.SetActive(false);
        }

        //picking up the umbrella, abilities?
        if(other.tag == "Umbrella"){
            other.gameObject.SetActive(false);
            obtainUmbrella();
        }

        //the task system to get the flowers
        if(other.tag == "Flower"){
            other.gameObject.SetActive(false);
            flowersPicked++;
            Debug.Log(flowersPicked);
            UpdateTask();
        }

        if (Input.GetButtonDown("Fire3") && other.tag == "LightTag")
        {
            Debug.Log("Hello");
        }

    }

    private void OnTriggerExit(Collider other)
    {
        
    }


    void Update()
    {
        CheckAnimation();

        input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector2 inputDir = input.normalized;

        CheckJump();

        CheckScale();

        //Rotating the character
        if (inputDir != Vector2.zero)
        {
            float targetRotation = Mathf.Atan2(inputDir.x, inputDir.y) * Mathf.Rad2Deg + camera.eulerAngles.y;
            transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y, targetRotation, ref turnSmoothVelocity, turnSmoothTime);

        }

        bool running = Input.GetKey(KeyCode.LeftShift);
        float speed = ((running) ? runSpeed : walkSpeed) * inputDir.magnitude;

        velocityY += Time.deltaTime * -gravity;

        velocity = transform.forward * speed + Vector3.up * velocityY;
        controller.Move(velocity * Time.deltaTime);

        if (controller.isGrounded)
        {
            velocityY = 0;
        }
    }

    void CheckJump()
    {
        if (controller.isGrounded && Input.GetButtonDown("Jump"))
        {
            velocityY = jumpHeight;
        }
    }

    //This method makes sense logically but is broken in game.
    void CheckAnimation()
    {
        //Checking inputs to determine animations
        if (Input.GetKey("a") || Input.GetKey("d"))
        {
            movingHorizontal = true;
        }
        if (Input.GetKey("w") || Input.GetKey("s"))
        {
            movingVertical = true;
        }
        if (!Input.GetKey("a") && !Input.GetKey("d"))
        {
            movingHorizontal = false;
        }
        if (!Input.GetKey("w") && !Input.GetKey("s"))
        {
            movingVertical = false;
        }

        //fall slower when holding space bar
        //if have the ability of course
        if (Input.GetButtonDown("Jump") & (!controller.isGrounded) && haveUmbrella)
        {
            gravity = 3f;
        }
        if (Input.GetButtonUp("Jump"))
        {
            gravity = 15f;
        }

        //Setting the animation based on the input
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            anim.SetTrigger("jump");
        }


        if (movingHorizontal == true || movingVertical == true)
        {
            anim.SetBool("isRunning", true);
        }
        else if (movingHorizontal == false && movingVertical == false)
        {
            //Debug.Log("Idle Anim");
            anim.SetBool("isRunning", false);
        }
        //Booleans aren't working correctly, maybe for accuracy try calling button directly

    }

    //Changes the scale based off input
    //Player may only be able to access certain areas or do certain things when a certain scale
    void CheckScale()
    {
        if (Input.GetKeyDown("c") && haveToy)
        {
            if (isStartingScale)
            {
                transform.localScale = new Vector3(5f, 5f, 5f);
                isStartingScale = false;
            }
            else if (!isStartingScale)
            {
                transform.localScale = startingScale;
                isStartingScale = true;
            }
        }
    }

    public void SetColour(int newColour)
    {
        colour = newColour;
    }

    public int getFlowers(){
        return flowersPicked;
    }

    void UpdateTask(){
        task.text = "Collect flowers[" + flowersPicked.ToString();
    }

    public bool playerHaveBow(){
        return haveBow;
    }

    public bool playerHaveLantern()
    {
        return haveLantern;
    }

    public bool playerHaveCandle()
    {
        return haveCandle;
    }

    public bool playerHaveToy(){
        return haveToy;
    }

    public bool playerHaveUmbrella(){
        return haveUmbrella;
    }

}