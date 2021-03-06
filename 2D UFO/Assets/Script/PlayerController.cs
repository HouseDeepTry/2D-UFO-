﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private GameObject gameControler;//để hiện panel khi cần

    public float Speed;
    public int winscore;

    private Rigidbody2D Rbd;

    private int count;

    public Text countText;
    public Text WinText;


    private void Start()
    {
        Rbd = GetComponent<Rigidbody2D>();
        count = 0;
        SetCountText();
        WinText.text = "";
        gameControler = GameObject.FindGameObjectWithTag("GameController");
    }
    private void FixedUpdate()
    {
        float MoveHorizontal = Input.GetAxis("Horizontal");
        float MoveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(MoveHorizontal,MoveVertical);
        Rbd.AddForce(movement*Speed);
    }
    //collision
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count += 1;
            SetCountText();
        }
        if(other.gameObject.CompareTag("Background"))
        {
            gameControler.GetComponent<LeverManager>().AppPanel();
        }
    }
    void SetCountText()
    {
        countText.text = "count:" + count.ToString();
        if(count>=winscore)
        {
            WinText.text = "you win";
            Time.timeScale = 0;
        }
    }
}
