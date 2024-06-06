using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeScript : MonoBehaviour
{
    public int NivelHambre;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TomarAlimento(int ValorAlimentario)
    {
        NivelHambre -= ValorAlimentario; 
        if (NivelHambre <= 0)
        {
            NivelHambre = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        AlimentoScript Alimento;
        Alimento = other.GetComponent<AlimentoScript>();
        if (Alimento)
        {
            TomarAlimento(Alimento.ValorAlimentario);
            Destroy(other.gameObject);
        }
    }
}
