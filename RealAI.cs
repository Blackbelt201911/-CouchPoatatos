using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public float Timer = 0;
    public float TimerCAP = 6;
    public float raylength = 5;
    public float EXTENDEDraylength = 15;
    public float number = 0;
    public float speedMULTIPLIER = 1;
    public bool PlayerCHASE = false;
    public float Ready = 0;
    public float Waiting1 = 0;
    public float Waiting2 = 0;
    public float Waiting3 = 0;
    public float speed = 1;


    // Start is no longer called before the secound frame update ):
    // Update is called twice per frame
    void Update()
    {
        int ADAMgetsCANADIANdollars = LayerMask.GetMask("TransparentFX");
        if (number == 0)
        {   
            if ((Ready == 1) && Waiting1 != 1)
            {
                Ready = 0;
                Waiting1 = 0;
                Waiting2 = 0;
                Waiting3 = 0;
                number = 1;
            }
            if ((Ready == 2) && Waiting2 != 1)
            {
                Ready = 0;
                Waiting1 = 0;
                Waiting2 = 0;
                Waiting3 = 0;
                number = 2;
            }
            if ((Ready == 3) && Waiting3 != 1)
            {
                Ready = 0;
                Waiting1 = 0;
                Waiting2 = 0;
                Waiting3 = 0;
                number = 3;
            }
            transform.eulerAngles = new Vector3(transform.rotation.y, transform.rotation.x, 270);
            RaycastHit2D hitMain = Physics2D.Raycast(transform.position + Vector3.right * 2, Vector2.right, raylength);
            transform.Translate(Vector2.up * Time.deltaTime * speed * speedMULTIPLIER);
            if (PlayerCHASE == false)
            {
                speedMULTIPLIER = 1;
                Timer = 0;
            }
            if (hitMain.collider != null)
            {
                GameObject hitObject = hitMain.transform.gameObject;
                if (hitObject.tag == "Wall")
                {
                    
                    number = Random.Range(0, 4);
                    Waiting1 = 0;
                    Waiting2 = 0;
                    Waiting3 = 0;
                    Ready = 0;
                }
                if (hitObject.tag == "Player")
                {
                    PlayerCHASE = true;
                }
            }
            if(Timer >= TimerCAP)
            {
                PlayerCHASE = false;
            }
            if(PlayerCHASE == true)
            {
                speedMULTIPLIER = 1.75f;
                RaycastHit2D hitRightLong = Physics2D.Raycast(transform.position + Vector3.right * 5, Vector2.right, EXTENDEDraylength, ADAMgetsCANADIANdollars);
                RaycastHit2D hitLeftShort = Physics2D.Raycast(transform.position + Vector3.left * 5, Vector2.left, raylength);
                RaycastHit2D hitLeftLong = Physics2D.Raycast(transform.position + Vector3.left * 5, Vector2.left, EXTENDEDraylength, ADAMgetsCANADIANdollars);
                RaycastHit2D hitUpShort = Physics2D.Raycast(transform.position + Vector3.up * 5, Vector2.up, raylength);
                RaycastHit2D hitUpLong = Physics2D.Raycast(transform.position + Vector3.up * 5, Vector2.up, EXTENDEDraylength, ADAMgetsCANADIANdollars);
                RaycastHit2D hitDownShort = Physics2D.Raycast(transform.position + Vector3.down * 5, Vector2.down, raylength);
                RaycastHit2D hitDownLong = Physics2D.Raycast(transform.position + Vector3.down * 5, Vector2.down, EXTENDEDraylength, ADAMgetsCANADIANdollars);
                RaycastHit2D DaigonalUpRight = Physics2D.Raycast(transform.position + Vector3.up * 2.5f + Vector3.right * 2.5f, new Vector2(1,1), EXTENDEDraylength, ADAMgetsCANADIANdollars);
                RaycastHit2D DaigonalUpLeft = Physics2D.Raycast(transform.position + Vector3.up * 2.5f + Vector3.left * 2.5f, new Vector2(-1,1), EXTENDEDraylength, ADAMgetsCANADIANdollars);
                RaycastHit2D DaigonalDownRight = Physics2D.Raycast(transform.position + Vector3.down * 2.5f + Vector3.right * 2.5f, new Vector2(1,-1), EXTENDEDraylength, ADAMgetsCANADIANdollars);
                RaycastHit2D DaigonalDownLeft = Physics2D.Raycast(transform.position + Vector3.down * 2.5f + Vector3.left * 2.5f, new Vector2(-1,-1), EXTENDEDraylength, ADAMgetsCANADIANdollars);
                Debug.DrawRay(transform.position + Vector3.right * 5, Vector2.right * EXTENDEDraylength, Color.red);
                Debug.DrawRay(transform.position + Vector3.left * 5, Vector2.left * EXTENDEDraylength, Color.red);
                Debug.DrawRay(transform.position + Vector3.left * 5, Vector2.left * raylength, Color.blue);
                Debug.DrawRay(transform.position + Vector3.up * 5, Vector2.up * EXTENDEDraylength, Color.red);
                Debug.DrawRay(transform.position + Vector3.up * 5, Vector2.up * raylength, Color.blue);
                Debug.DrawRay(transform.position + Vector3.down * 5, Vector2.down * EXTENDEDraylength, Color.red);
                Debug.DrawRay(transform.position + Vector3.down * 5, Vector2.down * raylength, Color.blue);
                Debug.DrawRay(transform.position + Vector3.up * 4 + Vector3.right * 4, new Vector2(1,1) * EXTENDEDraylength, Color.yellow);
                Debug.DrawRay(transform.position + Vector3.up * 4 + Vector3.left * 4, new Vector2(-1,1) * EXTENDEDraylength, Color.yellow);
                Debug.DrawRay(transform.position + Vector3.down * 4 + Vector3.right * 4, new Vector2(1,-1) * EXTENDEDraylength, Color.yellow);
                Debug.DrawRay(transform.position + Vector3.down * 4 + Vector3.left * 4, new Vector2(-1,-1) * EXTENDEDraylength, Color.yellow);
                Timer += 1 * Time.deltaTime;
                if (hitRightLong.collider != null)
                {
                    GameObject hitObject1 = hitRightLong.transform.gameObject;
                    if (hitObject1.tag == "Player")
                    {
                        Timer = 0;
                        Ready = 1;
                    }
                }

                if (hitUpLong.collider != null)
                {
                    GameObject hitObject2 = hitUpLong.transform.gameObject;
                    if (hitObject2.tag == "Player")
                    {
                        Timer = 0;
                        Ready = 1;
                    }
                }
                if (hitUpShort.collider != null)
                {
                    GameObject hitObject3 = hitUpShort.transform.gameObject;
                    if (hitObject3.tag == "Wall")
                    {
                        Waiting1 = 1;
                    }
                }
                if (hitUpShort.collider == null)
                {
                    Waiting1 = 0;
                }
                if (hitLeftLong.collider != null)
                {                    
                    GameObject hitObject4 = hitLeftLong.transform.gameObject;
                    if (hitObject4.tag == "Player")
                    {
                        Timer = 0;
                        Ready = 2;
                    }
                }
                if (hitLeftShort != null)
                {
                    GameObject hitObject5 = hitLeftShort.transform.gameObject;
                    if (hitObject5.tag == "Wall")
                    {
                        Waiting2 = 1;
                    }
                }
                if (hitLeftShort == null)
                {
                    Waiting2 = 0;
                }
                if (hitDownLong != null)
                {                   
                    GameObject hitObject6 = hitDownLong.transform.gameObject;
                    if (hitObject6.tag == "Player")
                    {
                        Timer = 0;
                        Ready = 3;
                    }
                }
                if (hitDownShort != null)
                {                    
                    GameObject hitObject7 = hitDownShort.transform.gameObject;
                    if (hitObject7.tag == "Wall")
                    {
                        Waiting3 = 1;
                    }
                }
                if (hitDownShort == null)
                {
                    Waiting3 = 0;
                }
                if (DaigonalDownLeft != null)
                {                    
                    GameObject hitObject8 = DaigonalDownLeft.transform.gameObject;
                    if (hitObject8.tag == "Player")
                    {
                        Ready = 2;
                    }
                }
                if (DaigonalDownRight != null)
                {                    
                    GameObject hitObject9 = DaigonalDownRight.transform.gameObject;
                    if (hitObject9.tag == "Player")
                    {
                        Ready = 3;
                    }
                }
                if (DaigonalUpLeft != null)
                {                    
                    GameObject hitObject10 = DaigonalUpLeft.transform.gameObject;
                    if (hitObject10.tag == "Player")
                    {
                        Ready = 2;
                    }
                }
                if ( DaigonalUpRight != null)
                {                                       
                    GameObject hitObject11 = hitUpShort.transform.gameObject;
                    if (hitObject11.tag == "Player")
                    {
                        Ready = 1;
                    }
                }
            }
            Debug.DrawRay(transform.position + Vector3.right * 2, Vector2.right * raylength, Color.green);
        }

        if (number == 1)
        {
            if ((Ready == 1) && Waiting1 != 1)
            {
                Ready = 0;
                Waiting1 = 0;
                Waiting2 = 0;
                Waiting3 = 0;
                number = 0;
            }
            if ((Ready == 2) && Waiting2 != 1)
            {
                Ready = 0;
                Waiting1 = 0;
                Waiting2 = 0;
                Waiting3 = 0;
                number = 2;
            }
            if ((Ready == 3) && Waiting3 != 1)
            {
                Ready = 0;
                Waiting1 = 0;
                Waiting2 = 0;
                Waiting3 = 0;
                number = 3;
            }
            transform.eulerAngles = new Vector3(transform.rotation.y, transform.rotation.x, 0);
            RaycastHit2D hitMain = Physics2D.Raycast(transform.position + Vector3.up * 5, Vector2.up, raylength);
            transform.Translate(Vector2.up * Time.deltaTime * speed * speedMULTIPLIER);
            if (PlayerCHASE == false)
            {
                speedMULTIPLIER = 1;
                Timer = 0;
            }
            if(PlayerCHASE == true)
            {

                speedMULTIPLIER = 1.75f;
                RaycastHit2D hitRightShort = Physics2D.Raycast(transform.position + Vector3.right * 5, Vector2.right, raylength);
                RaycastHit2D hitRightLong = Physics2D.Raycast(transform.position + Vector3.right * 5, Vector2.right, EXTENDEDraylength, ADAMgetsCANADIANdollars);
                RaycastHit2D hitLeftShort = Physics2D.Raycast(transform.position + Vector3.left * 5, Vector2.left, raylength);
                RaycastHit2D hitLeftLong = Physics2D.Raycast(transform.position + Vector3.left * 5, Vector2.left, EXTENDEDraylength, ADAMgetsCANADIANdollars);
                RaycastHit2D hitUpLong = Physics2D.Raycast(transform.position + Vector3.up * 5, Vector2.up, EXTENDEDraylength, ADAMgetsCANADIANdollars);
                RaycastHit2D hitDownShort = Physics2D.Raycast(transform.position + Vector3.down * 5, Vector2.down, raylength);
                RaycastHit2D hitDownLong = Physics2D.Raycast(transform.position + Vector3.down * 5, Vector2.down, EXTENDEDraylength, ADAMgetsCANADIANdollars);
                RaycastHit2D DaigonalUpRight = Physics2D.Raycast(transform.position + Vector3.up * 2.5f + Vector3.right * 2.5f, new Vector2(1,1), EXTENDEDraylength, ADAMgetsCANADIANdollars);
                RaycastHit2D DaigonalUpLeft = Physics2D.Raycast(transform.position + Vector3.up * 2.5f + Vector3.left * 2.5f, new Vector2(-1,1), EXTENDEDraylength, ADAMgetsCANADIANdollars);
                RaycastHit2D DaigonalDownRight = Physics2D.Raycast(transform.position + Vector3.down * 2.5f + Vector3.left * 2.5f, new Vector2(1,-1), EXTENDEDraylength, ADAMgetsCANADIANdollars);
                RaycastHit2D DaigonalDownLeft = Physics2D.Raycast(transform.position + Vector3.down * 2.5f + Vector3.right * 2.5f, new Vector2(-1,-1), EXTENDEDraylength, ADAMgetsCANADIANdollars);
                Debug.DrawRay(transform.position + Vector3.right * 5, Vector2.right * EXTENDEDraylength, Color.red);
                Debug.DrawRay(transform.position + Vector3.right * 5, Vector2.right * raylength, Color.blue);
                Debug.DrawRay(transform.position + Vector3.left * 5, Vector2.left * EXTENDEDraylength, Color.red);
                Debug.DrawRay(transform.position + Vector3.left * 5, Vector2.left * raylength, Color.blue);
                Debug.DrawRay(transform.position + Vector3.up * 5, Vector2.up * EXTENDEDraylength, Color.red); ;
                Debug.DrawRay(transform.position + Vector3.down * 5, Vector2.down * EXTENDEDraylength, Color.red);
                Debug.DrawRay(transform.position + Vector3.down * 5, Vector2.down * raylength, Color.blue);
                Debug.DrawRay(transform.position + Vector3.up * 2.5f + Vector3.right * 2.5f, new Vector2(1,1) * EXTENDEDraylength, Color.yellow);
                Debug.DrawRay(transform.position + Vector3.up * 2.5f + Vector3.left * 2.5f, new Vector2(-1,1) * EXTENDEDraylength, Color.yellow);
                Debug.DrawRay(transform.position + Vector3.down * 2.5f + Vector3.right * 2.5f, new Vector2(1,-1) * EXTENDEDraylength, Color.yellow);
                Debug.DrawRay(transform.position + Vector3.down * 2.5f + Vector3.left * 2.5f, new Vector2(-1,-1) * EXTENDEDraylength, Color.yellow);
                Timer += 1 * Time.deltaTime;
                if (hitRightLong.collider != null)
                {
                    Timer = 0;
                    Ready = 1;
                }
                if (hitRightShort.collider != null)
                {
                    Waiting1 = 1;
                }
                if (hitRightShort.collider == null)
                {
                    Waiting1 = 0;
                }
                if (hitUpLong.collider != null)
                {
                    Timer = 0;
                }
                if (hitLeftLong.collider != null)
                {
                    Timer = 0;
                    Ready = 2;
                }
                if (hitLeftShort != null)
                {
                    Waiting2 = 1;
                }
                if (hitLeftShort == null)
                {
                    Waiting2 = 0;
                }
                if (hitDownLong != null)
                {
                    Timer = 0;
                    Ready = 3;
                }
                if (hitDownShort != null)
                {
                    Waiting3 = 1;
                }
                if (hitDownShort == null)
                {
                    Waiting3 = 0;
                }
                if (DaigonalDownLeft != null)
                {
                    Ready = 2;
                }
                if (DaigonalDownRight != null)
                {
                    Ready = 1;
                }
                if (DaigonalUpLeft != null)
                {
                    Ready = 2;
                }
                if ( DaigonalUpRight != null)
                {
                    Ready = 1;
                }
            }
            
            if(Timer >= TimerCAP)
            {
                PlayerCHASE = false;
            }
            if (hitMain.collider != null)
            {
                GameObject hitObject = hitMain.transform.gameObject;
                
                if (hitObject.tag == "Wall")
                {

                    number = Random.Range(0, 4);
                }
                if (hitObject.tag == "Player")
                {
                    PlayerCHASE = true;
                }
            }
            
            Debug.DrawRay(transform.position + Vector3.up * 5, Vector2.up * raylength, Color.green);       
        }
        if (number == 2)
        {
            if ((Ready == 1) && Waiting1 != 1)
            {
                Ready = 0;
                Waiting1 = 0;
                Waiting2 = 0;
                Waiting3 = 0;
                number = 0;
            }
            if ((Ready == 2) && Waiting2 != 1)
            {
                Ready = 0;
                Waiting1 = 0;
                Waiting2 = 0;
                Waiting3 = 0;
                number = 1;;
            }
            if ((Ready == 3) && Waiting3 != 1)
            {
                Ready = 0;
                Waiting1 = 0;
                Waiting2 = 0;
                Waiting3 = 0;
                number = 3;
            }
            transform.eulerAngles = new Vector3(transform.rotation.y, transform.rotation.x, 90);
            RaycastHit2D hitMain = Physics2D.Raycast(transform.position + Vector3.left * 5, Vector2.left, raylength);
            transform.Translate(Vector2.up * Time.deltaTime * speed * speedMULTIPLIER);
            if (PlayerCHASE == false)
            {
                speedMULTIPLIER = 1;
                Timer = 0;
            }
            if(PlayerCHASE == true)
            {
                speedMULTIPLIER = 1.75f;
                RaycastHit2D hitRightShort = Physics2D.Raycast(transform.position + Vector3.right * 5, Vector2.right, raylength);
                RaycastHit2D hitRightLong = Physics2D.Raycast(transform.position + Vector3.right * 5, Vector2.right, EXTENDEDraylength, ADAMgetsCANADIANdollars);
                RaycastHit2D hitLeftLong = Physics2D.Raycast(transform.position + Vector3.left * 5, Vector2.left, EXTENDEDraylength, ADAMgetsCANADIANdollars);
                RaycastHit2D hitUpLong = Physics2D.Raycast(transform.position + Vector3.up * 5, Vector2.up, EXTENDEDraylength, ADAMgetsCANADIANdollars);
                RaycastHit2D hitUpShort = Physics2D.Raycast(transform.position + Vector3.up * 5, Vector2.up, raylength);
                RaycastHit2D hitDownShort = Physics2D.Raycast(transform.position + Vector3.down * 5, Vector2.down, raylength);
                RaycastHit2D hitDownLong = Physics2D.Raycast(transform.position + Vector3.down * 5, Vector2.down, EXTENDEDraylength, ADAMgetsCANADIANdollars);
                RaycastHit2D DaigonalUpRight = Physics2D.Raycast(transform.position + Vector3.up * 2.5f + Vector3.right * 2.5f, new Vector2(1,1), EXTENDEDraylength, ADAMgetsCANADIANdollars);
                RaycastHit2D DaigonalUpLeft = Physics2D.Raycast(transform.position + Vector3.up * 2.5f + Vector3.left * 2.5f, new Vector2(-1,1), EXTENDEDraylength, ADAMgetsCANADIANdollars);
                RaycastHit2D DaigonalDownRight = Physics2D.Raycast(transform.position + Vector3.down * 2.5f + Vector3.left * 2.5f, new Vector2(1,-1), EXTENDEDraylength, ADAMgetsCANADIANdollars);
                RaycastHit2D DaigonalDownLeft = Physics2D.Raycast(transform.position + Vector3.down * 2.5f + Vector3.right * 2.5f, new Vector2(-1,-1), EXTENDEDraylength, ADAMgetsCANADIANdollars);
                Debug.DrawRay(transform.position + Vector3.right * 5, Vector2.right * EXTENDEDraylength, Color.red);
                Debug.DrawRay(transform.position + Vector3.right * 5, Vector2.right * raylength, Color.blue);
                Debug.DrawRay(transform.position + Vector3.left * 5, Vector2.left * EXTENDEDraylength, Color.red);
                Debug.DrawRay(transform.position + Vector3.left * 5, Vector2.left * raylength, Color.blue);
                Debug.DrawRay(transform.position + Vector3.up * 5, Vector2.up * EXTENDEDraylength, Color.red);
                Debug.DrawRay(transform.position + Vector3.up * 5, Vector2.up * raylength, Color.blue);
                Debug.DrawRay(transform.position + Vector3.down * 5, Vector2.down * EXTENDEDraylength, Color.red);
                Debug.DrawRay(transform.position + Vector3.down * 5, Vector2.down * raylength, Color.blue);
                Debug.DrawRay(transform.position + Vector3.up * 2.5f + Vector3.right * 2.5f, new Vector2(1,1) * EXTENDEDraylength, Color.yellow);
                Debug.DrawRay(transform.position + Vector3.up * 2.5f + Vector3.left * 2.5f, new Vector2(-1,1) * EXTENDEDraylength, Color.yellow);
                Debug.DrawRay(transform.position + Vector3.down * 2.5f + Vector3.right * 2.5f, new Vector2(1,-1) * EXTENDEDraylength, Color.yellow);
                Debug.DrawRay(transform.position + Vector3.down * 2.5f + Vector3.left * 2.5f, new Vector2(-1,-1) * EXTENDEDraylength, Color.yellow);
                Timer += 1 * Time.deltaTime;
                if (hitRightLong.collider != null)
                {
                    Timer = 0;
                    Ready = 1;
                }
                if (hitRightShort.collider != null)
                {
                    Waiting1 = 1;
                }
                if (hitRightShort.collider == null)
                {
                    Waiting1 = 0;
                }
                if (hitUpLong.collider != null)
                {
                    Timer = 0;
                    Ready = 2;
                }
                if (hitUpShort.collider != null)
                {
                    Waiting2 = 1;
                }
                if (hitUpShort.collider == null)
                {
                    Waiting2 = 0;
                }
                if (hitLeftLong.collider != null)
                {
                    Timer = 0;
                }
                if (hitDownLong != null)
                {
                    Timer = 0;
                    Ready = 3;
                }
                if (hitDownShort != null)
                {
                    Waiting3 = 1;
                }
                if (hitDownShort == null)
                {
                    Waiting3 = 0;
                }
                if (DaigonalDownLeft != null)
                {
                    Ready = 3;
                }
                if (DaigonalDownRight != null)
                {
                    Ready = 1;
                }
                if (DaigonalUpLeft != null)
                {
                    Ready = 2;
                }
                if (DaigonalUpRight != null)
                {
                    Ready = 1;
                }
            }
            if(Timer >= TimerCAP)
            {
                PlayerCHASE = false;
            }
            if(hitMain.collider != null)
            {
                GameObject hitObject = hitMain.transform.gameObject;
                if (hitObject.tag == "Wall")
                {
                    number = Random.Range(0, 4);
                }
                if (hitObject.tag == "Player")
                {
                    PlayerCHASE = true;
                }
            }

            Debug.DrawRay(transform.position + Vector3.left * 5, Vector2.left * raylength, Color.green);
        }
        if (number == 3)
        {
            if ((Ready == 1) && Waiting1 != 1)
            {
                Ready = 0;
                Waiting1 = 0;
                Waiting2 = 0;
                Waiting3 = 0;
                number = 0;
            }
            if ((Ready == 2) && Waiting2 != 1)
            {
                Ready = 0;
                Waiting1 = 0;
                Waiting2 = 0;
                Waiting3 = 0;
                number = 1;
            }
            if ((Ready == 3) && Waiting3 != 1)
            {
                Ready = 0;
                Waiting1 = 0;
                Waiting2 = 0;
                Waiting3 = 0;
                number = 2;
            }
            transform.eulerAngles = new Vector3(transform.rotation.y, transform.rotation.x, 180);
            RaycastHit2D hitMain = Physics2D.Raycast(transform.position + Vector3.down * 15, Vector2.down, raylength);
            transform.Translate(Vector2.up * Time.deltaTime * speed * speedMULTIPLIER);
            if (PlayerCHASE == false)
            {
                speedMULTIPLIER = 1;
                Timer = 0;
            }
            if (PlayerCHASE == true)
            {
                speedMULTIPLIER = 1.75f;
                RaycastHit2D hitRightLong = Physics2D.Raycast(transform.position + Vector3.right * 5, Vector2.right, EXTENDEDraylength, ADAMgetsCANADIANdollars);
                RaycastHit2D hitRightShort = Physics2D.Raycast(transform.position + Vector3.right * 5, Vector2.right, raylength);
                RaycastHit2D hitLeftShort = Physics2D.Raycast(transform.position + Vector3.left * 5, Vector2.left, raylength);
                RaycastHit2D hitLeftLong = Physics2D.Raycast(transform.position + Vector3.left * 5, Vector2.left, EXTENDEDraylength, ADAMgetsCANADIANdollars);
                RaycastHit2D hitUpShort = Physics2D.Raycast(transform.position + Vector3.up * 5, Vector2.up, raylength);
                RaycastHit2D hitUpLong = Physics2D.Raycast(transform.position + Vector3.up * 5, Vector2.up, EXTENDEDraylength, ADAMgetsCANADIANdollars);
                RaycastHit2D hitDownLong = Physics2D.Raycast(transform.position + Vector3.down * 5, Vector2.down, EXTENDEDraylength, ADAMgetsCANADIANdollars);
                RaycastHit2D DaigonalUpRight = Physics2D.Raycast(transform.position + Vector3.up * 2.5f + Vector3.right * 2.5f, new Vector2(1,1), EXTENDEDraylength, ADAMgetsCANADIANdollars);
                RaycastHit2D DaigonalUpLeft = Physics2D.Raycast(transform.position + Vector3.up * 2.5f + Vector3.left * 2.5f, new Vector2(-1,1), EXTENDEDraylength, ADAMgetsCANADIANdollars);
                RaycastHit2D DaigonalDownRight = Physics2D.Raycast(transform.position + Vector3.down * 2.5f + Vector3.left * 2.5f, new Vector2(1,-1), EXTENDEDraylength, ADAMgetsCANADIANdollars);
                RaycastHit2D DaigonalDownLeft = Physics2D.Raycast(transform.position + Vector3.down * 2.5f + Vector3.right * 2.5f, new Vector2(-1,-1), EXTENDEDraylength);
                Debug.DrawRay(transform.position + Vector3.right *5, Vector2.right * raylength, Color.blue);
                Debug.DrawRay(transform.position + Vector3.right * 5, Vector2.right * EXTENDEDraylength, Color.red);
                Debug.DrawRay(transform.position + Vector3.left * 5, Vector2.left * EXTENDEDraylength, Color.red);
                Debug.DrawRay(transform.position + Vector3.left * 5, Vector2.left * raylength, Color.blue);
                Debug.DrawRay(transform.position + Vector3.up * 5, Vector2.up * EXTENDEDraylength, Color.red);
                Debug.DrawRay(transform.position + Vector3.up * 5, Vector2.up * raylength, Color.blue);
                Debug.DrawRay(transform.position + Vector3.down * 5, Vector2.down * EXTENDEDraylength, Color.red);
                Debug.DrawRay(transform.position + Vector3.up * 2.5f + Vector3.right * 2.5f, new Vector2(1,1) * EXTENDEDraylength, Color.yellow);
                Debug.DrawRay(transform.position + Vector3.up * 2.5f + Vector3.left * 2.5f, new Vector2(-1,1) * EXTENDEDraylength, Color.yellow);
                Debug.DrawRay(transform.position + Vector3.down * 2.5f + Vector3.right * 2.5f, new Vector2(1,-1) * EXTENDEDraylength, Color.yellow);
                Debug.DrawRay(transform.position + Vector3.down * 2.5f + Vector3.left * 2.5f, new Vector2(-1,-1) * EXTENDEDraylength, Color.yellow);
                Timer += 1 * Time.deltaTime;
                if (hitRightLong.collider != null)
                {
                    Timer = 0;
                    Ready = 1;
                }
                if (hitRightShort.collider != null)
                {
                    Waiting1 = 1;
                }
                if (hitRightShort.collider == null)
                {
                    Waiting1 = 0;
                }
                if (hitUpLong.collider != null)
                {
                    Timer = 0;
                    Ready = 2;
                }
                if (hitUpShort.collider != null)
                {
                    Waiting2 = 1;
                }
                if (hitUpShort.collider == null)
                {
                    Waiting2 = 0;
                }
                if (hitLeftLong.collider != null)
                {
                    Timer = 0;
                    Ready = 3;
                }
                if (hitLeftShort.collider != null)
                {
                    Waiting3 = 1;
                }
                if (hitLeftShort.collider == null)
                {
                    Waiting3 = 0;
                }
                if (hitDownLong != null)
                {
                    Timer = 0;
                }
                if (DaigonalDownLeft != null)
                {
                    Ready = 3;
                }
                if (DaigonalDownRight != null)
                {
                    Ready = 1;
                }
                if (DaigonalUpLeft != null)
                {
                    Ready = 3;
                }
                if (DaigonalUpRight != null)
                {
                    Ready = 1;
                }
            }
            if(Timer >= TimerCAP)
            {
                PlayerCHASE = false;
            }
            if (hitMain.collider != null)
            {
                GameObject hitObject = hitMain.transform.gameObject;
                if (hitObject.tag == "Wall")
                {
                    number = Random.Range(0, 4);
                }

                if (hitObject.tag == "Player")
                {
                    PlayerCHASE = true;
                }           
            }
            Debug.DrawRay(transform.position + Vector3.down * 5, Vector2.down * raylength, Color.green);
        }
    }
}