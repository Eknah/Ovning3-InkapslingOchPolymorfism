# �vning 3 - Inkapsling och polymorfism

**Svar Arv:13**
I klassen Bird

**Svar Arv:14**
I klassen Animal

**Svar Mer polymorfism:9**
F�r att klassen Horse inte �rver fr�n klassen Dog

**Svar Mer polymorfism:10**
Klassen Animal

**Svar Mer polymorfism:13**
F�r varje djur-objekt s� anropas den mest specialiserade versionen av Stats(), dvs s� l�ngt ner i arvskedjan som den kan hitta en version av Stats()-metoden;

**Svar Mer polymorfism:17**
I foreach-loopen �ver Animals-listan s� �r den itererade variabeln av typen Animal, vilket betyder att inuti foreach-loopen behandlas iterationsobjektet som en Animal, en klass som inte har n�gon metod eller interface f�r DigSpecificMethod(). Iterationsobjektet m�ste castas till en Dog f�rst.