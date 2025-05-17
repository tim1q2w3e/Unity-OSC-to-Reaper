using UnityEngine;
using extOSC;

public class PositionToOSC : MonoBehaviour
{
    public Transform trackedObject;
    public OSCTransmitter transmitter;
    public string oscAddress = "/head/pos";

    void Update()
{
    if (transmitter == null || trackedObject == null) return;

    Vector3 pos = trackedObject.position;

    // Position senden (wie bisher)
    var positionMessage = new OSCMessage(oscAddress);
    positionMessage.AddValue(OSCValue.Float(pos.x));
    positionMessage.AddValue(OSCValue.Float(pos.y));
    positionMessage.AddValue(OSCValue.Float(pos.z));
    transmitter.Send(positionMessage);

    // NEU: Lautstärke aus X-Position berechnen
    float volumeValue = Mathf.InverseLerp(-2f, 2f, pos.x); // skaliert von 0.0 bis 1.0

    var volumeMessage = new OSCMessage("/track/1/volume");
    volumeMessage.AddValue(OSCValue.Float(volumeValue));
    transmitter.Send(volumeMessage);
}

}
