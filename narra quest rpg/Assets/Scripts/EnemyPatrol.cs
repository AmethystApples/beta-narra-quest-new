using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] positions;
    int nextPosIndex;
    Transform nextPosition;
    public float moveSpeed;

    public bool flipCharacter = false;
    private bool m_facingRight = true;

    void Start()
    {
        nextPosition = positions[0];
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position == nextPosition.position)
        {
            nextPosIndex++;

            if(flipCharacter == true){
                Flip();
            }
            
            if(nextPosIndex>=positions.Length)
            {
                nextPosIndex = 0;
            }
            
            nextPosition = positions[nextPosIndex];
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPosition.position, moveSpeed * Time.deltaTime);
    }

    private void Flip()
	{
		// Switch the way the player is labelled as facing.
		m_facingRight = !m_facingRight;

		// Multiply the player's x local scale by -1.
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
