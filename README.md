### Zawartość
* [Analiza](#analiza)
* [Opis Klas](#opis klas)
* [Wzorce Projektowe](#wzorce)
* [Diagram Klas](#diagram klas)


## analiza


## Opis Klas

* AktualizacjaHandlarzy - **Jest to klasa generująca delegaty obsługujące aktualizajcę Handlarzy**
* AktualizacjaOsad - **Jest to klasa generująca delegaty obsługujące aktualizajcę Osad**
* AktualizacjaStanuSwiata - **Jest to klasa której obiekt jest wstanie zaktualizowac caly stan swiata**
* AktualizatorMapy - **Obiekt aktualizatora mapy sprawdza czy zaszły jakies zmiany w świecie (wielkosc wioski, pozycja handlarza) i koryguje te zmiany na mapie**

* FabrykaHandlarzy - ** generuje handlarzy z podana strategią i iloscia towaru ktora mogą ze sobą wozić**
* FabrykaOsad - ** Klasa która tworzy Osady**
* FabrykaZasobow - **Fabryka Zasobow to klasa ktora potrafi generowac gotowe do uzycia obiekty zasobow**

* GeneratorMapy - **Obiekt generatora mapy pozwala na naniesienie osad,handlarzy i tła na ramkę programu**
* GeneratorSwiata - **Jest to klasa której obiekt potrafi wygenerowac swiat na podstawie podanej strategi**
 
* Handlarz - ** Tworzy obiekty handlarza czyli bytu podróżującego pomiędzy Osadami przewożąc surowce
* Magazyn - **Magazyn jest obiektem posiadanym przez osadę, i przetrzymującym w swoich polach ilośći zasobów które posiada Osada**
* Osada - **Klasa Tworzaca obiekt osady**
* Targ - **Targ posiadany przez miasto i uzywany do komunikacji miedzy handlarzami a osadą**

* OknoGry - **Jest to główne okno gry**

* Populacja -	**Klasa Tworzaca obiekty populacji tj zawierajace informacie o liczbie ludnosci**
* PotencjalWydobywczy - **Potencjal wydobywczy bedzie gotowym obiektem zawierjacym liste obiektow zasobu jakie generuje dana osada**
* Swiat - **Obekt klasy swiat jest takim "kontenerem" trzymajcaym liste osad i liste handlarzy dostepnych w aktualnym świecie **
 
* TextBoxLabel - Klasa w całości zaczerpnięta od użytkownika Bob Bradley z [codeproject.org][link] obsługuje przeźroczysty TextBox 
[link]: http://www.codeproject.com/Articles/4390/AlphaBlendTextBox-A-transparent-translucent-textbo

* WozHandlarza - **klasa woz handlarza bedzie obiektem trzymajacym zasoby przewozone przez Handlarza**
* Zasob - **Obiekt zasobu przechowujacy jego nazwe wage i ilosc**
 
* LosowaniePotencjalu - **zwraca liste wylosowanych zasobow które będzie generować osada**
* LosowanieZasobu - **Tworzy obiekt potrafiacy wylosowac liczbe z zadanego mu przedzialu**



** Moje przykładowe strategie:** 
*PodstawowaStrategiaAktualizacjiSwiata
*PodstawowaStrategiaGenerowaniaSwiata
*PodstawowaStrategiaHandlarza
*PodstawowaStrategiaHandlu
*PodstawowaStrategiaOsady
** Są to przygotowane przezemnie przykładowe strategie tego jak powinna działać aktualizacja świata,handlarzy itp**
 
Interfejsy:

*IStrategiaAktualizacjiSwiata - **Interfejs Aktualizacji swiata ma metody zwracajace co ile dni handlarz zmienia swój stan, podobnie tyczy się to Osady**
*IStrategiaGenerowaniaSwiata -	**Jest to ogolny interfejs generowania swiata, ktory mówi o tym ile osad wygenerowac na mapie, ilu handlarzy,i jaka pojemność bedzie miał wóz handlarze podaje też z jakich strategi handlarza,handlu i Osady bedziemy korzystac**
*IStrategiaHandlarza - **Interfejs mówiący o tym jak wyznaczać nowy cel podróży dla handlarza oraz w jaki sposob sie przemieszcza**
*IStrategiaHandlu - ** Interfejs opisujacy jak wyglada wymiana towaru miedzy targiem a handlarzem **
*IStrategiaOsady - **Interfejs strategi osady wymusza metody których używa osada do zaktualizowania swojego statusu tj. stanow magazynowych i populacji, strategie bedą wymienne**
 


