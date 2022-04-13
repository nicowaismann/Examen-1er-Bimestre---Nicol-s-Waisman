using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tema5 : MonoBehaviour
{

    public string producto1;
    public string producto2;
    public string producto3;

    public float precio1;
    public float precio2;
    public float precio3;

    float precioConDescuento1;
    float precioConDescuento2;
    float precioConDescuento3;

    public int cantidad1;
    public int cantidad2;
    public int cantidad3;

    float Descuento;

    float precioFinalSinDescuento;

    float precioFinalConDescuento;




    // Start is called before the first frame update
    void Start()
    {
        Descuento = (precio1 - precioConDescuento1) + (precio2 - precioConDescuento2) + (precio3 - precioConDescuento3);
        float precioFinalSinDescuento = (precio1 * cantidad1) + (precio2 * cantidad2) + (precio3 * cantidad3);

        if (cantidad1 < 1 || cantidad2 < 1 || cantidad3 < 1 || precio1 < 1 || precio2 < 1 || precio3 < 1)
        {
            Debug.Log("Error, la cantidad o el precio de algun producto es menor a uno");
        }


        else if (cantidad1 > 3) {
            precioConDescuento1 = precio1 * 0.80f;
        }

        else if (cantidad2 > 3)
        {
            precioConDescuento2 = precio2 * 0.80f;
        }

        else if (cantidad3 > 3)
        {
            precioConDescuento3 = precio3 * 0.80f;
        }

        
        

   else{
            Debug.Log("La compra final sería de $" + precioFinalSinDescuento + " , pero si le restamos el descuento que sería de $" + Descuento + " y el total de la compra con descuento quedaría en $" + (precioFinalSinDescuento - Descuento));
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
