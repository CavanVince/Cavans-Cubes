using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public Text CountText;
    public Text WinText;
    public Material[] material;
    Renderer rend;
    public GameObject Jump;

    private Rigidbody rb;
    private int count;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        WinText.text = "";
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
        Jump.GetComponent<JumpBabyV2>().enabled = false;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
            if (other.gameObject.CompareTag("JumpBoost"))
            {
                other.gameObject.SetActive(false);
                count = count + 1;
                SetCountText();
            rend.sharedMaterial = material[1];
            Jump.GetComponent<JumpBabyV2>().enabled = true;
            }
        
    }

    void SetCountText()
    {
        CountText.text = "Score " + count.ToString();
        if (count == 16)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Level 1");
        }
    }

}
