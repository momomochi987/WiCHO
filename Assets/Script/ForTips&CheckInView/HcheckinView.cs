﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HcheckinView : MonoBehaviour
{
    private Renderer H1_Renderer, H2_Renderer, H3_Renderer, H4_Renderer, H5_Renderer;
    public GameObject H1_ball, H2_ball, H3_ball, H4_ball, H5_ball;
    public GameObject H_canva;
    public bool HshowUp;

    void Start()
    {       
        H1_Renderer = H1_ball.GetComponent<MeshRenderer>();
        H2_Renderer = H2_ball.GetComponent<MeshRenderer>();
        H3_Renderer = H3_ball.GetComponent<MeshRenderer>();
        H4_Renderer = H4_ball.GetComponent<MeshRenderer>();
        H5_Renderer = H5_ball.GetComponent<MeshRenderer>();
    }
    private void Update()
    {
        if (H1_Renderer.isVisible || H2_Renderer.isVisible || H3_Renderer.isVisible || H4_Renderer.isVisible || H5_Renderer.isVisible)
        {
            HshowUp = true;
        }
        else 
        {
            HshowUp = false;
        }

        if (HshowUp)
        {
            H_canva.SetActive(true);
        }
        else {
            H_canva.SetActive(false);
        }
    }

    public bool H1_IsVisible()
    {
        return H1_Renderer.isVisible;
    }
    public bool H2_IsVisible()
    {
        return H2_Renderer.isVisible;
    }
    public bool H3_IsVisible()
    {
        return H3_Renderer.isVisible;
    }
    public bool H4_IsVisible()
    {
        return H4_Renderer.isVisible;
    }
    public bool H5_IsVisible()
    {
        return H5_Renderer.isVisible;
    }
}