// See https://aka.ms/new-console-template for more information
/*Le informazioni sul libro che dobbiamo chiedere all’utente sono le seguenti:
Titolo
Autore
ISBN
Numero pagine
Peso del libro
Larghezza, Altezza e Profondità del libro
Valutazione media
Numero di recensioni
se è disponibile in versione Kindle
se la copertina flessibile è disponibile
Per ognuna delle seguente informazioni è importante individuare bene il tipo corretto.
A questo punto stampiamo bene le informazioni acquisite sulla console, dove per <<nomeVariabile>> indica di stampare l’informazione contenuta nella variabile.
*/

// single line

/*multi
 line
*/

string title = "Clean Code: A Handbook of Agile Software Craftsmanship";
string author = "Dean Wampler & Robert C. Martin";
long isbn = 9780132350884;
int pageNumber = 431;
int bookWeight = 800;
float bookDimensionX = 17.78f;
float bookDimensionY = 2.79f;
float bookDimensionZ = 23.37f;
float bookValue = 9.8f;
int bookReviews = 50000;
bool kindleVersion = true;
bool flexibleCover = true;

/*ISBN: <<isbn>>
Numero delle pagine: <<numeroPagine>> pagine
Peso del libro: <<pesoLibro>> kg
Dimensioni del libro: <<larghezza>> cm x <<lunghezza>> cm x <<profondita>> cm
Informazioni Amazon:
Numero di recensioni: <<numeroRecensioni>> recensioni
Valutazione media: <<valutazioneMedia>> stelline
Kindle disponibile: Si o No
Copertina flessibile disponibile: Si o No
*/
Console.WriteLine($"Titolo: {title}");
Console.WriteLine($"Autore: {author}");
Console.WriteLine($"ISBN: {isbn}");
Console.WriteLine($"Numero di pagine: {pageNumber}");
Console.WriteLine($"Peso del libro: {bookWeight} gr");
Console.WriteLine($"Dimensioni del libro: {bookDimensionX} x {bookDimensionY} x {bookDimensionZ} cm");
Console.WriteLine($"Valutazione media: {bookValue}");
Console.WriteLine($"Numero di recensioni: {bookReviews}");
Console.WriteLine($"Versione e-book: {kindleVersion}");
Console.WriteLine($"Copertina flessibile: {flexibleCover}");
