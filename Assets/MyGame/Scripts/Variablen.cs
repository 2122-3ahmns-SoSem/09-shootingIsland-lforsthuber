using UnityEngine;

public enum Himmelsrichtungen
{
    Nord,
    Sued,
    West,
    Ost
}

public class Variablen : MonoBehaviour
{
    public GameObject x;
    
    Color farbe;

    int anzTuerenInstanz = 4;
    int anzTueren2;
    int anzTueren3;

    bool fahren;
    string name;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Himmelsrichtungen.Nord + "" + Himmelsrichtungen.Sued + "" + Himmelsrichtungen.West + "" + Himmelsrichtungen.Ost);

        ////Anwendungsbeispiel Nr. 1
        //name = "HTL Salzburg";
        //Debug.Log("Hallo " + name);

        ////Anwendungsbeispiel Nr. 2
        //anzTueren = 3;
        //anzTueren2 = 8;
        //anzTueren3 = 5;
        //Debug.Log(anzTueren + anzTueren2 + anzTueren3);

        ////Anwendungsbeispiel Nr. 3
        //farbe = Color.red;
        //gameObject.GetComponent<Renderer>().material.color = farbe;

        farbe = Color.red;
        Debug.Log("Red " + farbe.ToString());

        farbe = Color.yellow;
        Debug.Log("Yellow " + farbe.ToString());

        farbe = Color.white;
        Debug.Log("White " + farbe.ToString());

        Debug.Log(x.ToString());
        Debug.Log(anzTuerenInstanz.ToString());
        Debug.Log("bool fahren " + fahren.ToString());

        int.anzTueren = int.Parse("4");
        float anzTuerenf = float.Parse("4");

        anzTueren = int.Parse("eins");

        Debug.Log(anzTueren + " " + anzTuerenf + " " + anzTuerenInstanz);
    }
}
