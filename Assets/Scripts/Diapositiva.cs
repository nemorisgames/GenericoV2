using UnityEngine;
using System.Collections;

public class Diapositiva : MonoBehaviour {
    public enum TipoDispositiva {TextoDerecha, TextoIzquierda, Titulo};
    public TipoDispositiva tipo = TipoDispositiva.TextoDerecha;
    public PanelInformacionBullets[] panelInformacionBullets;
    public UITexture imagenPrincipal;
    public UILabel titulo;
    public UILabel subTitulo;
    public GameObject[] sonidoBotones;
    public PanelDiapositivas panelDiapositivas;
    public GameObject botonSiguienteDiapositiva;
    public GameObject botonAnteriorDiapositiva;
    // Use this for initialization
	void Start () {
	    
	}

    public void verDiapositivaAnterior()
    {
        panelDiapositivas.cambiarDiapositiva(false);
    }

    public void verDiapositivaSiguiente()
    {
        panelDiapositivas.cambiarDiapositiva(true);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
