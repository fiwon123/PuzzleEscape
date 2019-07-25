﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject cam = null, ceiling = null, floor = null, goBack = null, top = null, down = null , aquario = null, bedDown = null, bedTop = null, paper = null; 

    private int posXFrame0 = 0;
    private int posXFrame1 = 18;
    private int posXFrame2 = 36;
    private int posXFrame3 = 54;

    public void MoveCamToFrame(int frame)
    {
        Vector3 newPos = cam.transform.position;

        switch (frame)
        {
            case 0:
                newPos.x = posXFrame0;
                break;
            case 1:
                newPos.x = posXFrame1;
                break;
            case 2:
                newPos.x = posXFrame2;
                break;
            case 3:
                newPos.x = posXFrame3;
                break;
        }

        cam.transform.position = newPos;
    }

    public void ShowCeiling()
    {
        ceiling.SetActive(true);
        goBack.SetActive(true);
        HideOthersFrames();
    }

    public void ShowFloor()
    {
        floor.SetActive(true);
        goBack.SetActive(true);
        HideOthersFrames();
    }

    public void ShowAquario()
    {
        aquario.SetActive(true);
        goBack.SetActive(true);
        HideOthersFrames();
    }

    public void ShowBedDown()
    {
        bedDown.SetActive(true);
        goBack.SetActive(true);
        HideOthersFrames();
    }

    public void ShowPaper()
    {
        paper.SetActive(true);
        goBack.SetActive(true);
        HideOthersFrames();
    }

    public void ShowBedTop()
    {
        bedTop.SetActive(true);
        goBack.SetActive(true);
        HideOthersFrames();
    }

    public void Hide()
    {
        paper.SetActive(false);
        bedTop.SetActive(false);
        bedDown.SetActive(false);
        aquario.SetActive(false);
        floor.SetActive(false);
        ceiling.SetActive(false);
        goBack.SetActive(false);
        ShowOtherFrames();
    }

    private void HideOthersFrames()
    {
        foreach (Transform child in transform.GetChild(0).transform)
        {
            child.gameObject.SetActive(false);
        }

        top.SetActive(false);
        down.SetActive(false);
    }

    private void ShowOtherFrames()
    {
        foreach (Transform child in transform.GetChild(0).transform)
        {
            child.gameObject.SetActive(true);
        }

        top.SetActive(true);
        down.SetActive(true);
    }
}
