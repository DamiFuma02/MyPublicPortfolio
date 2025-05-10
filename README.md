# MyPublicPortfolio

> [Microsoft ASP.NET Documentation](https://learn.microsoft.com/it-it/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-9.0&tabs=visual-studio)

> La cartella root del repository rappresenta una Solution di C#, in cui ogni sottocartella rappresenta un singolo progetto (anche indipendente dagli altri) inerente alla stessa soluzione

> L'obiettivo del repository è di mostrare pubblicamente l'avanzamento delle versioni della web app



## First Test

> Prime prove con il framework ASP.NET generando una webapp tramite sfruttando i Model View Controller 

> Il **pattern architetturale** Model-View-Controller (MVC) suddivide un'app in tre componenti principali: Modello, Vista e Controller. 
Il pattern MVC consente di creare app più semplici da aggiornare e sottoporre a test rispetto alle app monolitiche tradizionali.

> Le app basate sul pattern MVC contengono:

* **Modelli**: Classi che rappresentano i dati dell'app. Le classi modello usano la logica di convalida per applicare le regole business per tali dati. In genere, gli oggetti del modello recuperano e archiviano lo stato del modello in un database. In questa esercitazione, un modello Movie recupera i dati dei film da un database, li fornisce alla vista o li aggiorna. I dati aggiornati vengono scritti in un database.
* **Viste**: Le viste sono i componenti che visualizzano l'interfaccia utente (UI) dell'app. In genere questa interfaccia utente presenta i dati del modello.
* **Controllers**: Sono classi che:
    * Gestire le richieste del browser.
    * Recuperare i dati del modello.
    * Chiamare i modelli di visualizzazione che restituiscono una risposta.


> Questo modello consente di ottenere la separazione dei problemi: la logica dell'interfaccia utente appartiene alla visualizzazione. 
La logica di input risiede nel controller. 
La logica di business risiede nel modello. 
Questa separazione consente di gestire la complessità durante la creazione di un'app, perché consente di lavorare su un aspetto dell'implementazione alla volta senza influire sul codice di un altro. 
Ad esempio, è possibile lavorare sul codice della vista senza dipendere dal codice della logica aziendale.



