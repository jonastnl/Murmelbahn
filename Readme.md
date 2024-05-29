# Unity
## Install
Unity Hub
Add project from disk
select project

## Magnet
Der Magnet ist eine Pipe und wurde mit dem Unity *ProBuilder*-Asset erstellt. 

![alt text](image-1.png)

ProBuilder importieren: 
1. Window
2. Package Manager
3. Unity Registry
4. Probuilder

ProBuilder verwenden
1. Tools
2. ProBuilder
3. ProBuilder Window

Auf jede Pipe wurde das Skript *Magnets* gezogen. Darin wird die Tastenbelegung zum aktivieren/deaktivieren der Magnete festgelegt.

![alt text](image-2.png)

## Strecke
Die Strecke wurde als FBX-Datei aus Blender in Unity importiert. (Drag'n'drop) Dann muss noch ein Mesh Collider hinzugefügt werden, um Kollision mit der Murmel zu ermöglichen. Murmel kann von der Strecke abkommen -> Idee: für mehr Sicherheit evtl. eine nicht sichtbare geschlossene Bahn und eine offene Bahn ohne Mesh Collider.

![alt text](image-3.png)

# Code
Bei Aktivierung des Magneten wird der Murmel *Force* in richtung Magnet zugeführt. Die Magneten arbeiten mit dem Tag "Marble". Der Tag muss der Murmel hinzugefügt werden. 

![alt text](image-4.png)

# Blender
## Kurve erstellen
1. Add -> Mesh -> Plane

![alt text](image-5.png)

2. *Tab* -> rechtsclick -> Merge Vertices -> At Center

![alt text](image-7.png)

3. *E* (Extend) (ctrl + linksclick zum ausrichten am Mesh) -> Strecke modellieren (Kurven folgen im nächsten schritt)

![alt text](image-8.png)

4. *A* (Alles markieren) -> *Ctrl + Shift + B* -> Maus nach rechts bewegen fügt zwischenpunte für Rundung ein (Mausrad = menge der Punkte)

![alt text](image-9.png)

5. *A* -> *Tab* (EditMode -> ObjectMode)

6. Object -> Convert -> Curve

![alt text](image-10.png)

7. rechts auf Curve-Einstellungen

![alt text](image-11.png)

8. Geometry -> Depth

![alt text](image-12.png)

9. optional TwistMethod: Z-Up; FillMode: Half

![alt text](image-13.png)

10. Drehen: *A* -> *Tab* -> *A*/Einzelne Punkte Markieren -> *Ctrl + T* ->drehen

![alt text](image-14.png)

11. *A* -> Object/Convert/Mesh

12. Add Modifier -> Solidify -> edit Thickness

![alt text](image-15.png)

13. Export: File/Export/FBX