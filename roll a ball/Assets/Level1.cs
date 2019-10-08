using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Level1 : MonoBehaviour {
    public float speed;
    public Text CountText;
    public Text WinText;

    private Rigidbody rb;
    private int count;
    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody>();
        count = 16;
        SetCountText();
        WinText.text = "";
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
    }
    void SetCountText()
    {
        CountText.text = "Score " + count.ToString();
        if (count == 24)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Level 2");
        }
    }
}

