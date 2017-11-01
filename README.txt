Dit practicum is gemaakt door:
Jasper Peters (*******)

Features:
- Kleur en zwart wit optie (kleur door middel van HSV->Color)
- Kan een mandlebrot als alle members van de Julia Set tekenen (door invullen van reële waarde en imaginaire waarde voor een van de Julia set figuren)
- Werkt met multi-threading om optimaal gebruik te maken van de beschikbare processor kracht
- Auto checkbox om voor elke verandering aan de opties automatisch opnieuw het figuur te tekenen
- Met de muis kan ook ingezoomt worden op het figuur (centreert op aangeklikte punt)


Hoe werkt de multi-threading:
- Er worden zoveel thread aangemaakt als dat er logical cores aanwezig zijn op je PC (Meer is in theorie niet efficienter)
- Elk thread rekent een even groot deel uit
- Elk thread rekent verdeeld over het gehele figuur uit om zo te proberen zo min mogelijk verschil te hebben in berekenings tijd tussen de threads
	- Wordt gedaan door "interlaces" te berekenen en achteraf dit weer tot een geheel te maken.
