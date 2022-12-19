using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationScript : MonoBehaviour
{
    public GameObject leverAnim;
    
    bool animActivation = false;

    Camera camera;
    RaycastHit[] hits;
    // Start is called before the first frame update
   

    private void Start()
    {
        camera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }
    private void Update()
    {
     

        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = camera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            hits = Physics.RaycastAll(ray,10f);
                Debug.Log("Hit");
            for (int i = 0; i < hits.Length; i++)
            {
                RaycastHit hit = hits[i];
                if (hit.collider.gameObject.tag == "Lever")
                {
                    Debug.Log("LeverOpen");
                    animActivation = !animActivation;
                    leverAnim.GetComponent<Animator>().SetBool("LeverUp", animActivation);
                    Debug.DrawRay(camera.gameObject.transform.position,hit.collider.gameObject.transform.position);
                }
            }
               
            
        }
        
    }

}
