using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
<<<<<<< HEAD

public class VRTeleport : MonoBehaviour
{
    public Transform m_VRRig;
    public string m_teleportButton;
=======
public class VRTeleport : MonoBehaviour
{
    public string m_teleportButton;
    public Transform m_VRRig;

>>>>>>> e2c8afdb4c8085446a76c8c1764836bdca153776
    LineRenderer m_line;
    RaycastHit m_hit;
    bool m_canTeleport;

<<<<<<< HEAD

    // Start is called before the first frame update
    void Start()
    {
        //RaycastHit hit;
        //Physics.Raycast(transform.position, transform.forward, out hit);
        m_line = GetComponent<LineRenderer>();

=======
    void Start()
    {
        m_line = GetComponent<LineRenderer>();
>>>>>>> e2c8afdb4c8085446a76c8c1764836bdca153776
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton(m_teleportButton))
        {
<<<<<<< HEAD
            if (Physics.Raycast(transform.position, transform.forward, out m_hit, 100f))
=======
            if (Physics.Raycast(transform.position, transform.forward, out m_hit))
>>>>>>> e2c8afdb4c8085446a76c8c1764836bdca153776
            {
                m_line.enabled = true;
                m_line.SetPosition(0, transform.position);
                m_line.SetPosition(1, m_hit.point);
                m_canTeleport = true;
<<<<<<< HEAD

=======
>>>>>>> e2c8afdb4c8085446a76c8c1764836bdca153776
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
<<<<<<< HEAD
               m_VRRig.position = m_hit.point;
            }
        }
    }
}
=======
                m_VRRig.position = m_hit.point;
            }
        }
    }
}
>>>>>>> e2c8afdb4c8085446a76c8c1764836bdca153776
