# Övning 3 - Inkapsling och polymorfism

**Svar Arv:13**
I klassen Bird

**Svar Arv:14**
I klassen Animal

**Svar Mer polymorfism:9**
För att klassen Horse inte ärver från klassen Dog

**Svar Mer polymorfism:10**
Klassen Animal

**Svar Mer polymorfism:13**
För varje djur-objekt så anropas den mest specialiserade versionen av Stats(), dvs så långt ner i arvskedjan som den kan hitta en version av Stats()-metoden;

**Svar Mer polymorfism:17**
I foreach-loopen över Animals-listan så är den itererade variabeln av typen Animal, vilket betyder att inuti foreach-loopen behandlas iterationsobjektet som en Animal, en klass som inte har någon metod eller interface för DigSpecificMethod(). Iterationsobjektet måste castas till en Dog först.