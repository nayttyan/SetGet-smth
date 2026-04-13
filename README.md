# SetGet-smth
**Projekta apraksts**

Šī ir vienkārša RPG spēle, kas darbojas caur UI. Spēlētājs redz savu un pretinieka HP un var uzbrukt, izmantojot pogas. Pēc spēlētāja uzbrukuma pretinieks automātiski uzbrūk atpakaļ. Ja pretinieks nomirst, parādās jauns. Ja spēlētājs nomirst, spēle beidzas.

**OOP principi**

**Mantošana**
- Ir bāzes klase Character, no kuras manto Player un pretinieki (Zombie, Skeleton, Orc).

**Enkapsulācija**
Tiek izmantotas īpašības ar get un set, piemēram:
- Health
- ShieldHP
- CharName

**Polimorfisms**
Ir overload metode:
- TakeDamage(float)
- TakeDamage(Weapon)
- Ir override metodes dažādās klasēs (Attack, GetDamage)

**Abstrakcija**
Ir abstrakta klase Weapon, no kuras manto:
- NormalWeapon
- PoisonWeapon
- FireWeapon

Papildu uzdevumi
- Spēlē ir 3 dažādi pretinieki ar atšķirīgiem uzbrukumiem
- Spēlētājs var mainīt ieročus
- Ir vairoga sistēma, kas samazina bojājumus

Papildus
- Spēlētājs var ievadīt savu vārdu
- UI parāda spēlētāju, ieročus un pretiniekus ar attēliem
- Ir "Game Over" teksts
