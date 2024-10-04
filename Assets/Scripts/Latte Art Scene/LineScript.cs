using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LineScript : MonoBehaviour
{
    private float speed;
    private int score = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreMessage;
    public Collider2D[] colliders;
    public float timeLimit = 1f;

    private float[] colliderPositions;
    private int currentColliderIndex = 0;
    private float colliderEntryTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score.ToString();
        scoreMessage.text = "".ToString();

        // Get the positions of all the colliders
        colliderPositions = new float[colliders.Length];
        for (int i = 0; i < colliders.Length; i++)
        {
            colliderPositions[i] = colliders[i].transform.position.x;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime); // Moving the circle across the line

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpacePressed(); //Refrences a function or defintion when spacebar has been clicked
        }

        // Check if time limit has exceeded since entering the collider
        if (currentColliderIndex < colliders.Length)
        {
            float timeSinceEntry = Time.time - colliderEntryTime;
            if (timeSinceEntry > timeLimit)
            {
                currentColliderIndex++;
                if (currentColliderIndex >= colliders.Length)
                {
                    currentColliderIndex = 0;
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collider")) //Detecing buttons with the collider tag
        {
            // Move to the next collider
            currentColliderIndex++;
            colliderEntryTime = Time.time;

            // If all colliders have been passed, start again from the first one
            if (currentColliderIndex >= colliders.Length)
            {
                currentColliderIndex = 0;
            }
        }
    }

    private void SpacePressed()
    {
        if (currentColliderIndex < colliders.Length)
        {
            // Calculate the distance between the circle and the current collider
            float distance = Mathf.Abs(transform.position.x - colliderPositions[currentColliderIndex]);

            // Check if the circle is within the collider's bounds
            if (distance < colliders[currentColliderIndex].bounds.extents.x)
            {
                // Increase score and update score text
                score += 1;
                scoreText.text = "Score: " + score.ToString();
                scoreMessage.text = "Perfect!";
                Debug.Log("Hit!");
            }
            else
            {
                scoreMessage.text = "Missed!";
                Debug.Log("Missed!");
            }

            // Move to the next collider
            currentColliderIndex++;
            if (currentColliderIndex >= colliders.Length)
            {
                currentColliderIndex = 0;
            }
        }
    }
}
