# flappy bird 

* Irjuk át a Form Text tulajdonságát -> Flappy Bird -re
* Form BackColor tulajdonságánál módosítsuk a háttért

- Szükségünk van 4 PictureBox-ra ezután,
  ezek lesznek majd a 1x talaj, 2x akadály (cső), 1x idegesitő madár

* igazitsuk a következőképpen a PcitureBox-okat:

     Flappy Bird
     ┌───────────────────────Form───────────────────┬───────┬──────────┐
     │                                              │       │          │
     │                                              │       │          │
     │                                              │       │          │
     │                                              │cső 2x │          │
     │                                              │       │          │
     │                                              │       │          │
     │     ┌────────┐                               └───────┘          │
     │     │köcsög  │                                                  │
     │     │madár   │                                                  │
     │     └────────┘                                                  │
     │                                                                 │
     │                                                                 │
     │                             ┌───────┐                           │
     │                             │cső 1x │                           │
     │                             │       │                           │
     │                             │       │                           │
     │                             │       │                           │
     │                             │       │                           │
     │                             │       │                           │
     ├┬────────────────────────────┴───────┴──────────────────────────┬┤
     ││          Ez a föld                                            ││
     │┼───────────────────────────────────────────────────────────────┼│
     └─────────────────────────────────────────────────────────────────┘

    * nevezzük át a PictureBoxokat az ábra alapján
    * flappyBird, pipeTop, pipeBottom, ground
    * helyezzünk el a Form-on egy label-t bal felül
    * irjuk át a Text tulajdonságát "Score: 0"-ra, formázzuk is 
    * a label Design tulajdonságát irjuk át scoreText-re
    * itt letudjátok tölteni a képeket:
    * vagy kereshettek tetszőlegest a neten
    * jobb click a flappyBird PictureBox-ra és Choose Image...