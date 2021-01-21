﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]

public class VRTeleport : MonoBehaviour
{
    public Transform m_VRRig;
    public string m_teleportButton;
    LineRenderer m_line;
    RaycastHit m_hit;
    bool m_canTeleport;


    // Start is called before the first frame update
    void Start()
    {
        //RaycastHit hit;
        //Physics.Raycast(transform.position, transform.forward, out hit);
        m_line = GetComponent<LineRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton(m_teleportButton))
        {
            if (Physics.Raycast(transform.position, transform.forward, out m_hit, 100f))
            {
                m_line.enabled = true;
                m_line.SetPosition(0, transform.position);
                m_line.SetPosition(1, m_hit.point);
                m_canTeleport = true;

            }
            else
            {
                m_line.enabled = false;
                m_canTeleport = false;
            }
        }
        else if (Input.GetButtonUp(m_teleportButton))
        {
            m_line.enabled = false;
            if (m_canTeleport == true)
            {
               m_VRRig.position = m_hit.point;
            }
        }
    }
}