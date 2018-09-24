using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click2Move : MonoBehaviour {

    //Distance at one click to move
    [SerializeField] Vector3 moveX = new Vector3(1, 0, 0);
    //Speed per seconds
    [SerializeField] float speed = 0.5f;
    Vector3 targetPoint;
    bool isMoving = false;

    // Use this for initialization
    void Start()
    {
        moveX = new Vector3(1, 0, 0);
        targetPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            if (isMoving) {
                targetPoint += moveX;
            }
            else {
                isMoving = true;
                targetPoint = transform.position + moveX;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, targetPoint, speed * Time.deltaTime);
        if (transform.position == targetPoint) {
            isMoving = false;
        }
    }

}
/*
Vector3 moveX;

void Start()
{
    moveX = new Vector3(1, 0, 0);
}
void Update()
{

    if (GameStartBool == true) {

        if (Application.isEditor) {

            if (Input.GetMouseButtonUp(0)) {

                if (transform.position == target) {

                    SetTargetPosition();
                }
            }

        }
        else {

            if (Input.touchCount > 0) {

                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Began) {

                    if (transform.position == target) {

                        SetTargetPosition();
                    }
                }
            }
        }
    }

    Move();
}

void SetTargetPosition()
{

    target = transform.position + moveX;
    return;
}
void Move()
{

    transform.position = Vector3.MoveTowards(transform.position, target, step * Time.deltaTime);
}
*/
