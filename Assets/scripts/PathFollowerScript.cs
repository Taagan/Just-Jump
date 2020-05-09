using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PathFollowerScript : MonoBehaviour
{
   public Transform pathParent;
    int index;
    Transform targetPoint;
    float speed = MovementPlayer.speedCopy;
    // Start is called before the first frame update
    void Awake()
    {
        index = 0;
        targetPoint = pathParent.GetChild(index);
    }

    void OnDrawGizmos()
    {
        
        Vector2 from, to;

        for (int a = 0; a < pathParent.childCount -1; a++)
        {
            from = pathParent.GetChild(a).position;
            to = pathParent.GetChild((a + 1 /* % pathParent.childCount*/)).position; // TA BORT KOMMENTAR FÖR LOOPADE PATHS, aka sista punkten connectar till start punkten igen.
            Gizmos.color = new Color(1, 0, 0);
            Gizmos.DrawLine(from, to);
        }
    }


    //Update is called once per frame
        void FixedUpdate()
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, speed * Time.deltaTime);

            if (Vector2.Distance(transform.position, targetPoint.position) < 0.1f)
            {
                    index++;
                    //index %= pathParent.childCount;
                    targetPoint = pathParent.GetChild(index);
            }
        }    
}


