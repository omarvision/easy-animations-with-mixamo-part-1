using UnityEngine;

public class Franky : MonoBehaviour
{
    public float Movespeed = 3.5f;
    public float Turnspeed = 120f;
    public Animator anim = null;

    private void Update()
    {
        //moving - WASD, Arrows, Gamepad Left Analog
        float horz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");     // -1..0..1

        this.transform.Translate(Vector3.forward * Movespeed * vert * Time.deltaTime);
        this.transform.localRotation *= Quaternion.AngleAxis(horz * Turnspeed * Time.deltaTime, Vector3.up);

        anim.SetFloat("Blend", vert);

        //jump  (Fire1 = <left-ctrl> or <Gamepad A>)
        if (Input.GetKeyDown(KeyCode.Space) == true || Input.GetButtonDown("Fire1") == true) 
        {
            anim.SetTrigger("Jump");
        }
    }
}
