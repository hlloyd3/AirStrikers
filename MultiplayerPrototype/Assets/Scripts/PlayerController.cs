using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Photon.Pun;

public class PlayerController : MonoBehaviour
{
    PhotonView view;

    public LayerMask moveable;

    private NavMeshAgent myAgent;

    private void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        view = GetComponent<PhotonView>();
    }

    private void Update()
    {
        if (view.IsMine)
        {
            if (Input.GetMouseButton(0))
            {
                Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hitInfo;

                if (Physics.Raycast(myRay, out hitInfo, 100, moveable))
                {
                    myAgent.SetDestination(hitInfo.point);
                }
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Puck")
        {
            StartCoroutine("CollideTime");
        }
    }

    IEnumerator CollideTime()
    {
        myAgent.enabled = false;
        yield return new WaitForSeconds(0.5f);
        myAgent.enabled = true;
    }

}
