using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement; 

public class FreeLook : MonoBehaviour {

    public float speed;
    public float rotateSpeed; 

	// Update is called once per frame
	void LateUpdate () {

        float xAxisValue = Input.GetAxis("Horizontal");
        float zAxisValue = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.L))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                this.transform.Rotate(rotateSpeed * Vector3.up * Time.deltaTime, Space.World);
            }
            else
            {
                this.transform.Translate(new Vector3(speed, 0, 0));
            }   
        }

        if (Input.GetKey(KeyCode.J))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                this.transform.Rotate(-1 * rotateSpeed * Vector3.up * Time.deltaTime, Space.World);
            }
            else
            {
                this.transform.Translate(new Vector3(-1 * speed, 0, 0));
            }
        }

        if (Input.GetKey(KeyCode.I))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                this.transform.Translate(new Vector3(0, 0, speed));
            }
            else
            {
                this.transform.Translate(new Vector3(xAxisValue, 0.0f, zAxisValue));
            }
        }

        if (Input.GetKey(KeyCode.K))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                this.transform.Translate(new Vector3(0, 0, -1 * speed));
            }
            else
            {
                this.transform.Translate(new Vector3(xAxisValue, 0.0f, zAxisValue));
            }
        }


    }
}
