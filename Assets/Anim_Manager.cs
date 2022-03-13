using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Anim_Manager : MonoBehaviour
{
    public Animator PergaminoIzq;
    public Animator PergaminoDer;
    public Animator PergaminoInt;
    public Animator PergaminoBajo;
    public Animator PergaminoBajoInt;
    public Animator NuevoObjetivo;
    public Animator Objetivos;
    public ObjetiveManager OBMnager;
    public bool checkanim;
    public bool ratacompleted;
    public bool basuracompleted;
    public bool ventanacompleted;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartAnims());
    }

    public void Update()
    {
        //if (OBMnager.ratacompleted == true && OBMnager.checkanim == true || OBMnager.basuracompleted == true && OBMnager.checkanim == true || OBMnager.ventanacompleted == true && OBMnager.checkanim == true)
        //{
        //    StartAnimThroughtOBM();
        //}
        checkanim = OBMnager.checkanim;
        ratacompleted = OBMnager.ratacompleted;
        basuracompleted = OBMnager.basuracompleted;
        ventanacompleted = OBMnager.ventanacompleted;
    }

    //public void StartAnimThroughtOBM()
    //{
    //    StartCoroutine(StartAnims2());
    //}

    //IEnumerator StartAnims2()
    //{
    //    yield return new WaitForSeconds(0.5f);
    //    Objetivos.SetBool("stop", false);
    //    PergaminoIzq.SetBool("stop", false);
    //    PergaminoDer.SetBool("stop", false);
    //    PergaminoInt.SetBool("stop", false);
    //    NuevoObjetivo.SetBool("stop", false);
    //    PergaminoBajo.SetBool("stop", false);
    //    PergaminoBajoInt.SetBool("stop", false);
    //    yield return new WaitForSeconds(4f);
    //    Objetivos.SetBool("stop", true);
    //    yield return new WaitForSeconds(1.8f);
    //    PergaminoIzq.SetBool("stop", true);
    //    PergaminoDer.SetBool("stop", true);
    //    PergaminoInt.SetBool("stop", true);
    //    NuevoObjetivo.SetBool("stop", true);
    //    PergaminoBajo.SetBool("stop", true);
    //    PergaminoBajoInt.SetBool("stop", true);
    //    StopCoroutine(StartAnims2());

    //}

    IEnumerator StartAnims()
    {
        yield return new WaitForSeconds(2f);
        PergaminoIzq.SetBool("idle", true);
        PergaminoDer.SetBool("idle", true);
        PergaminoInt.SetBool("idle", true);
        NuevoObjetivo.SetBool("idle", true);
        yield return new WaitForSeconds(1f);
        PergaminoBajo.SetBool("idle", true);
        PergaminoBajoInt.SetBool("idle", true);
        Objetivos.SetBool("idle", true);
        yield return new WaitForSeconds(4f);
        Objetivos.SetBool("stop", true);
        yield return new WaitForSeconds(1.8f);
        PergaminoIzq.SetBool("stop", true);
        PergaminoDer.SetBool("stop", true);
        PergaminoInt.SetBool("stop", true);
        NuevoObjetivo.SetBool("stop", true);
        PergaminoBajo.SetBool("stop", true);
        PergaminoBajoInt.SetBool("stop", true);
    }
}
