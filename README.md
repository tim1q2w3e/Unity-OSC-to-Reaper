[Demo] (Unity-Reaper-View.png)

**Unity-OSC-to-Reaper**

Dieses Projekt demonstriert die Übertragung von Positionsdaten eines bewegten 3D-Objekts in Unity via OSC (Open Sound Control) an Reaper. Damit kann z. B. die Lautstärke (Volume) eines Tracks in Reaper in Echtzeit gesteuert werden – basierend auf Objektpositionen im Raum.

**Ziel**

- Erlernen und Anwenden objektorientierter Programmierung (C# in Unity)
- Aufbau eines funktionierenden OSC-Senders in Unity
- Live-Steuerung eines Parameters in einer DAW (Reaper)
- Vorbereitung für Spatial-Audio-, Headtracking- oder VR-Projekte

**Setup**

**Voraussetzungen**

- Unity 2022.3.x oder neuer
- extOSC Library (https://github.com/Iam1337/extOSC)
- Reaper DAW (v7 oder neuer)
- Python (optional für OSC-Dummy)
- Git & GitHub (für Versionierung)

**Installation & Start**

- Repository klonen: git clone https://github.com/DEIN-BENUTZERNAME/Unity-OSC-to-Reaper.git
- Projekt in Unity öffnen
- Szene MainScene laden
- Komponente OSCTransmitter auf IP 127.0.0.1 und Port 9000 setzen
- In Reaper:
  - Preferences > Control/OSC/Web
  - Add: OSC (local)
  - Port: 9000
  - Pattern config: Default
- Unity: Play drücken → Kugelbewegung beginnt
- Reaper: Track 1 Volume-Fader reagiert auf die Bewegung

**Aufbau**

- OscSphereMover.cs – simuliert Bewegung in Kreisbahn
- PositionToOSC.cs – sendet Positionsdaten & Lautstärke über OSC
- extOSC – externe Library zur OSC-Kommunikation
- README.md – Projektbeschreibung

**Signalfluss**

Unity (OscSphereMover):
→ PositionToOSC
→ extOSC Transmitter
→ UDP/OSC
→ Reaper (/track/1/volume)

**Erweiterungsideen**

- Integration von Meta Quest Headtracking
- Bidirektionale OSC-Kommunikation (Reaper → Unity)
- Rotation & Blickrichtung
- Ambisonics & Spatial Audio-Interfaces
- GitHub-Collaboration & Branch-basierte Weiterentwicklung
