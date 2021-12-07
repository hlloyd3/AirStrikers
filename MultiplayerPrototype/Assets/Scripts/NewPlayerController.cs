using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class NewPlayerController : MonoBehaviour
{

    Rigidbody rb;

    PhotonView view;

    public LayerMask moveable;

    public Transform target;

    public float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        view = GetComponent<PhotonView>();
        target = this.gameObject.transform.GetChild(0);
        target.parent = null;
    }

    private void FixedUpdate()
    {
        Vector3 dir = target.transform.position - gameObject.transform.position;
        rb.AddForce(dir * speed);
        if (view.IsMine)
        {
            if (Input.GetMouseButton(0))
            {
                Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hitInfo;

                if (Physics.Raycast(myRay, out hitInfo, 100, moveable))
                {
                    target.position = hitInfo.point;
                    Debug.Log(hitInfo.point);
                }
            }
        }
    }

}
