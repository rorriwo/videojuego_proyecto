using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer1 : MonoBehaviour
{
    [SerializeField]
    private float velocidad = 1; //variable para aumentar la velocidad de movimiento
    private float movX, movY; //variables para mover en eje X, Y

    public float fuerzaSalto = 1;
    private int totalSaltosDisponibles = 2;
    private bool saltando = true;

    public static float modificadorVelocidad = 1;

    public float velocidadDeslizamiento = 1;
    public bool deslizando = false;

    public static bool jugadorVivo = true;

    public Rigidbody2D Rb;

    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        //Rb.GetComponent<Rigidbody2D>();
        anim = GameObject.FindGameObjectWithTag("RenderJugador").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (jugadorVivo)
        {
            movX = Input.GetAxis("Horizontal");
            movY = Input.GetAxisRaw("Vertical");

            //Debug.Log("x:" + movX + "y" + movY);// para imprimir valores en consola
            
            

            if (movX > 0)
            {
                this.transform.localScale = new Vector3(1, 1, 1);
                anim.SetInteger("velocidad", 1);
            }
            else if (movX < 0)
            {
                this.transform.localScale = new Vector3(-1, 1, 1);
                anim.SetInteger("velocidad", 1);
            }
            else
            {
                anim.SetInteger("velocidad", 0);
            }


            //Rb.velocity = new Vector2(movX * velocidad, movY); //una forma para mover nuestro personaje

            if (Input.GetKeyDown(KeyCode.Space) && totalSaltosDisponibles > 0)
            {
                
                Rb.velocity = new Vector2(Rb.velocity.x, 0);
                Rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
                //Debug.Log("Saltando...");
                //anim.SetTrigger("QuiereSaltar");
                totalSaltosDisponibles--;
            }
            anim.SetFloat("velocidadCaida", Rb.velocity.y);
        }
    }


    void FixedUpdate()
    {
        if (jugadorVivo)
        {
            if (deslizando){
                Rb.velocity = new Vector2(Rb.velocity.x, Mathf.Clamp(Rb.velocity.y, -velocidadDeslizamiento, 10));
                if(movX > 0)
                {
                    Rb.velocity = new Vector2(Mathf.Clamp(movX * velocidad * Time.fixedDeltaTime, -100, 0), Rb.velocity.y);
                }
                else if (movX < 0)
                {
                    Rb.velocity = new Vector2(Mathf.Clamp(movX * velocidad * Time.fixedDeltaTime, 0, 100), Rb.velocity.y);
                }
            }
            else
            {
                Rb.velocity = new Vector2(movX * velocidad * modificadorVelocidad * Time.fixedDeltaTime, Rb.velocity.y);
            }

        }
        
        //Rb.velocity = new Vector2(movX * velocidad * modificadorVelocidad * Time.fixedDeltaTime, Rb.velocity.y);
        //una forma para mover nuestro personaje; deltatime multiplica el elvalor de tiempo para aumentar el rango de tiempo sin sacrificar frames


    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            totalSaltosDisponibles = 2;
            anim.SetBool("tocandoSuelo", true);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            anim.SetBool("tocandoSuelo", false);
        }
    }

    /*public void aplicarSalto()
    {
        Rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
    }*/

}
