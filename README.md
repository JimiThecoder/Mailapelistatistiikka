# Mailapelistatistiikka

## Kuvaus

Mailapelistatistiikka on Windows Forms -sovellus, jolla voi kirjata ja seurata omia otteluita (esim. tennis, sulkapallo, padel). Sovellus laskee automaattisesti pelattujen otteluiden määrän, voittoprosentin ja näyttää listan viimeisimmistä otteluista.

## Käyttötarkoitus

Sovellus on tarkoitettu oman pelaamisen seurantaan - voin ottelun jälkeen kirjata tulokset ja seurata kehitystäni ajan mittaan.

## Ominaisuudet

- Ottelun kirjaus: laji, vastustaja, päivämäärä, erien pisteet, muistiinpanot
- Automaattinen voitto/häviö/tasapeli-laskenta
- Tilastonäkymä: otteluiden kokonaismäärä, voittoprosentti, viimeisimmät ottelut
- Yksittäisen ottelun poisto
- Kaikkien otteluiden tyhjennys
- Tiedot tallentuvat JSON-tiedostoon, säilyvät sovelluksen sulkemisen jälkeen

## Näkymät

### Form1 - Uusi ottelu (tyhjänä)
<img width="777" height="474" alt="image" src="https://github.com/user-attachments/assets/301f4042-7d62-492f-be03-6dbf104e8dec" />

### Form1 - Täytetty lomake ja onnistunut tallennus
<img width="773" height="471" alt="image" src="https://github.com/user-attachments/assets/7b125bda-7e27-47ca-b190-936ee6ac2a04" />

### Form2 - Tilastonäkymä
<img width="794" height="475" alt="image" src="https://github.com/user-attachments/assets/268ec52a-1d85-4c0c-b28f-bd858a6172eb" />

### Form2 - Tilastonäkymä usealla tallennetulla ottelulla
<img width="797" height="475" alt="image" src="https://github.com/user-attachments/assets/c1b0c089-b828-4bb2-bb00-621d84fd1114" />

## Vuokaavio
<img width="481" height="718" alt="image" src="https://github.com/user-attachments/assets/1d52707c-9f08-41b8-a869-d65a11fa1c40" />

## Koodin pääkohdat

### Ottelu.cs
Kuvaa yhden pelatun ottelun tiedot (laji, vastustaja, päivämäärä, erien pisteet). Sisältää logiikan voiton/häviön/tasapelin laskemiseen.

### TiedonHallinta.cs
Vastaa tietojen tallentamisesta ja lukemisesta JSON-tiedostoon.

### Form1.cs
Ottelun kirjauslomakkeen logiikka: syötteen validointi, tallennus.

### Form2.cs
Tilastonäkymän logiikka: tiedoston lukeminen, tilastojen laskenta, ottelun poisto.

## Jatkokehitysideat

- Voittoprosentin kehitys graafisena kaaviona ajan yli
- Sovelluksen kuvake (icon)
- Tietojen vienti CSV-muotoon
  
