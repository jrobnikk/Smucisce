Smučišče – C# aplikacija
Opis projekta

Projekt Smučišče je aplikacija, napisana v programskem jeziku C#, ki simulira delovanje smučišča. Sistem omogoča pregled smučarskih prog, vlečnic ter smučarske opreme, poleg tega pa omogoča tudi upravljanje izposoje opreme.

Aplikacija uporablja objektno usmerjeno programiranje (OOP), kjer so posamezni elementi smučišča predstavljeni kot razredi (npr. proga, vlečnica, oprema, izposoja). Sistem omogoča različne funkcionalnosti za običajne uporabnike in administratorje.

Glavni namen projekta je prikaz uporabe konceptov objektno usmerjenega programiranja, kot so:
- razredi in objekti
- dedovanje
- abstraktni razredi
- dogodki (events)
- delo s kolekcijami

1. Prenos projekta

Odprite GitHub repozitorij projekta (https://github.com/jrobnikk/Smucisce.git).
Kliknite gumb Code.
Izberite možnost Download ZIP.
Preneseno datoteko razširite na poljubno mesto na vašem računalniku.

2. Zahteve za delovanje

Za uspešen zagon aplikacije je potreben:

- Windows operacijski sistem
- Visual Studio 2022
- .NET Framework

3. Odpiranje projekta

Odprite mapo prenesenega projekta.
Poiščite datoteko Faza 1 - Jernej Robnik.sln.
Datoteko odprite v programu Visual Studio.

4. Zagon programa

V Visual Studio kliknite Build in Build Solution.
Po uspešnem prevajanju pritisnite Start ali tipko F5.
Program se zažene in prikaže se uporabniški vmesnik.

Navodila za uporabo

Uporabnik najprej izbere možnost uporabnika ali administatorja.

Uporabniške možnosti:

Pregled prog

Uporabnik lahko v aplikaciji pregleda vse smučarske proge.
Za vsako progo so prikazani osnovni podatki, kot so:

naziv proge
težavnost proge
dolžina proge
Pregled vlečnic

Uporabnik lahko pregleda vse vlečnice na smučišču.

Pri vsaki vlečnici so prikazani naslednji podatki:

naziv vlečnice
kapaciteta na uro
stanje obratovanja

Administratorske možnosti:

zaganjanje in ustavljanje vlečnic
odpiranje in zapiranje prog

Upravljanje opreme

Sistem omogoča pregled smučarske opreme, ki je na voljo za izposojo.

Uporabnik lahko:

pregleda seznam opreme
pregleda podatke o posameznem kosu opreme

Administrator lahko:
pregleda prihodke od izposojanje opreme

Izposoja opreme

Sistem omogoča evidenco izposoje smučarske opreme.

Uporabnik lahko:

registrira novo izposojo opreme
pregleda trenutno izposojeno opremo
vrne izposojeno opremo

Struktura projekta

Projekt je razdeljen na več delov:

Smucisce.Core

Vsebuje osnovne razrede in logiko aplikacije, kot so:

- Proga
- Vlecnica
- Oprema
- Izposoja
- WinForms aplikacija

Vsebuje grafični uporabniški vmesnik, preko katerega uporabnik uporablja sistem.

Avtor:
Jernej Robnik
Srednja šola za kemijo, elektrotehniko in računalništvo, ŠČ Celje
