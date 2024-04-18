In questo esercizio vi chiedo di definire qualche funzione di utilità che poi potete usare per poter fare operazioni complesse nei vostri programma principale.

Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:

- **void StampaArray(int[] array)**: che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”. Potete prendere quella fatta in classe questa mattina

- **int Quadrato(int numero)**: che vi restituisca il quadrato del numero passato come parametro.

- **int[] ElevaArrayAlQuadrato(int[] array)**: che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato. Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)

- **int sommaElementiArray(int[] array)**: che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.

Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9] già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:

- Stampare l’array di numeri fornito a video

- Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])

- Stampare la somma di tutti i numeri

- Stampare la somma di tutti i numeri elevati al quadrati

**BONUS:** Convertire le funzioni appena dichiarate in funzioni generiche, ossia funzioni che possono lavorare con array di numeri interi **di lunghezza variabile**, ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via.
A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, e dopo di che questi vengono inseriti a mano dall’utente esternamente. Rieseguire il programma con l’input preso esternamente dall’utente.




ESERCIZIO AGGIUNTIVO DEL POMERIGGIO



Scrivere un piccolo programma che esegue le seguenti funzioni:

(Si inserisca ogni funzionalità in uno o più metodi a seconda delle necessità)


- Permette di Calcolare l'area di un cerchio  (I numeri sono in virgola quindi attenzione.)

- Converta i gradi da Celsius a Farenheit

- Verificare se il numero fornito in input è un numero primo o no

- Concatenare due stringhe date in ingresso (BONUS: Permettere all'utente anche di scegliere il carattere per la concatenazione)

- Verificare se una parola data in input è palindroma (HELP: la funzione Equals delle stringhe ci può aiutare)