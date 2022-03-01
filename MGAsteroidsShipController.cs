using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MGAsteroidsShipController : MonoBehaviour
{
    // liefert diee Drehung
    public abstract float getSteering();

    // liefert die Beschleunigung
    public abstract float getAcceleration();

}
