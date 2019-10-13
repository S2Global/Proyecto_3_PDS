﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ToggleButtons : MonoBehaviour
{
    public GameObject useScroll;
    public GameObject targetText;
    public GameObject select1;
    public GameObject select2;
    public GameObject select3;
    public GameObject select4;
    public GameObject select5;
    public GameObject select6;
    public GameObject select7;
    public GameObject scrollButton1;
    public GameObject scrollButton2;
    public GameObject scrollButton3;
    public GameObject scroll1;
    public GameObject scroll2;
    public GameObject scroll3;

    public void activateButtons()
    {
        targetText.GetComponent<TextMeshProUGUI>().text = "SELECT A TARGET";
        select1.SetActive(true);
        select2.SetActive(true);
        select3.SetActive(true);
        select4.SetActive(true);
        select5.SetActive(true);
        select6.SetActive(true);
        select7.SetActive(true);
        useScroll.SetActive(false);
        scrollButton1.SetActive(false);
        scrollButton2.SetActive(false);
        scrollButton3.SetActive(false);
    }

    public void deactivateButtons()
    {
        targetText.GetComponent<TextMeshProUGUI>().text = "TURN OVER";
        select1.SetActive(false);
        select2.SetActive(false);
        select3.SetActive(false);
        select4.SetActive(false);
        select5.SetActive(false);
        select6.SetActive(false);
        select7.SetActive(false);
    }

    public void predeactivateButtons()
    {
        select1.SetActive(false);
        select2.SetActive(false);
        select3.SetActive(false);
        select4.SetActive(false);
        select5.SetActive(false);
        select6.SetActive(false);
        select7.SetActive(false);
    }

    public void activateScrollButtons()
    {
        scrollButton1.SetActive(true);
        scrollButton2.SetActive(true);
        scrollButton3.SetActive(true);
    }
}
