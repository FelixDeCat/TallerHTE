using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ParcelUiDebugger : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textmesh_alumno;
    [SerializeField] TextMeshProUGUI textmesh_parcela_title;
    [SerializeField] TextMeshProUGUI textmesh_parcela_alumno;

    public static ParcelUiDebugger instance;

    Animator myAnim;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

        myAnim = GetComponentInChildren<Animator>();
    }

    public static void Delete()
    {
        instance.textmesh_alumno.text = "";
        instance.textmesh_parcela_title.text = "";
        instance.textmesh_parcela_alumno.text = "";
    }
    public static void Debug(string txt_alumno, string txt_Parcela)
    {
        instance.myAnim.Play("TextAppear");
        instance.textmesh_alumno.text = txt_alumno;
        instance.textmesh_parcela_title.text = txt_Parcela;
        instance.textmesh_parcela_alumno.text = txt_alumno;
    }
}
