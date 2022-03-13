using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ObjetiveManager : MonoBehaviour
{
    //TextMeshPro
    public TextMeshPro Obj_rata;
    public TextMeshPro Obj_basura;
    public TextMeshPro Obj_ventanas;

    //Sprites
    public SpriteRenderer rata_sp;
    public SpriteRenderer basura_sp;
    public SpriteRenderer ventana_sp;
    public Sprite rata_sp_completed;
    public Sprite basura_sp_completed;
    public Sprite ventana_sp_completed;

    //SpriteRendererAnimations
    public Image objetive_name_completed;
    public Image objetives_completed;


    //SpritesCompletedAnimation
    public Sprite rat_anim_completed;
    public Sprite basura_anim_completed;
    public Sprite ventana_anim_completed;
    public Sprite rat_basura_anim_completed;
    public Sprite rat_ventana_anim_completed;
    public Sprite basura_ventana_completed;
    public Sprite all_completed;


    //Ints Counters
    public int ratascounter;
    public int basuracounter;
    public int ventanacounter;

    //Bools
    public bool ratacompleted;
    public bool basuracompleted;
    public bool ventanacompleted;
    public bool checkanim = true;

    //Animators
    public Animator UI_final;
    public Animator UI_final_letras;

    //Scripts
    public Basura basurita;
    public Anim_Manager anim;


    private void Start()
    {
        rata_sp.sprite = rata_sp.sprite;
        basura_sp.sprite = basura_sp.sprite;
        ventana_sp.sprite = ventana_sp.sprite;
    }

    private void Update()
    {
        Obj_rata.text = ("Elimina roedores [" + basurita.contador_ratas + "/" + ratascounter +"]");
        Obj_basura.text = ("Recoge basura [" + basurita.contador + "/" + basuracounter + "]");
        Obj_ventanas.text = ("Abre ventanas [" + basurita.contador_ventana + "/" + ventanacounter + "]");    
        

        if(basurita.contador_ratas == ratascounter && checkanim == true)
        {
            Obj_rata.fontStyle = FontStyles.Strikethrough;
            ratacompleted = true;
            rata_sp.sprite = rata_sp_completed;
            //StartCoroutine(ChangeBoolCheckingAnim());
        }
        if (basurita.contador == basuracounter && checkanim == true)
        {
            Obj_basura.fontStyle = FontStyles.Strikethrough;
            basuracompleted = true;
            basura_sp.sprite = basura_sp_completed;
            //StartCoroutine(ChangeBoolCheckingAnim());
        }
        if (basurita.contador_ventana == ventanacounter && checkanim == true)
        {
            Obj_ventanas.fontStyle = FontStyles.Strikethrough;
            ventanacompleted = true;
            ventana_sp.sprite = ventana_sp_completed;
            //StartCoroutine(ChangeBoolCheckingAnim());
        }

        CheckAnims();
    }

    public void CheckAnims()
    {
        if(ratacompleted == true && basuracompleted == false && ventanacompleted == false)
        {
            objetives_completed.sprite = rat_anim_completed;
        }
        if (ratacompleted == false && basuracompleted == true && ventanacompleted == false)
        {
            objetives_completed.sprite = basura_anim_completed;
        }
        if (ratacompleted == false && basuracompleted == false && ventanacompleted == true)
        {
            objetives_completed.sprite = ventana_anim_completed;
        }
        if (ratacompleted == true && basuracompleted == true && ventanacompleted == false)
        {
            objetives_completed.sprite = rat_basura_anim_completed;
        }
        if (ratacompleted == true && basuracompleted == false && ventanacompleted == true)
        {
            objetives_completed.sprite = rat_ventana_anim_completed;
        }
        if (ratacompleted == false && basuracompleted == true && ventanacompleted == true)
        {
            objetives_completed.sprite = basura_ventana_completed;
        }
        if (ratacompleted == true && basuracompleted == true && ventanacompleted == true)
        {
            UI_final.SetBool("idle", true);
            UI_final_letras.SetBool("idle", true);
        }
    }

    IEnumerator ChangeBoolCheckingAnim()
    {
        yield return new WaitForSeconds(1);
        checkanim = false;
        StopCoroutine(ChangeBoolCheckingAnim());
    }
}
