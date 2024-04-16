# Social network analyzer
## Description
Small project which acts as admission test for .NET position to <redacted>.

## Assignment description (in Czech language)
Cílem tohoto testu je vytvořit webovou aplikaci, která bude sloužit pro analýzu dat ze sociální sítě.
Přiložený soubor network-data.txt obsahuje anonymizované informace o přátelství ze skutečné sociální sítě, kde na každém řádku jsou mezerou oddělené ID uživatelů, kteří jsou přátelé.
### Zadání
1.	Základním úkolem je vytvořit webovou aplikaci pomocí C# / ASP.NET / ASP.NET Core, buď jako MVC aplikaci nebo single-page aplikaci s WebAPI a například React či Next.js.
2.	Při startu aplikace automaticky vytvoří databázi, pokud ještě neexistuje, a vytvoří všechny potřebné tabulky, dle vámi navrženého databázového modelu.
3.	Aplikace umožní importovat data soubor ve výše uvedeném formátu (založit nový dataset) a tuto sadu dat pojmenovat. Jeden dataset bude mít importované data pouze jednou. Data při tomto importu uložíte do databáze. 
4.	Na webu zobrazte analýzu, kde bude možné si vybrat ze skupin importovaných dat a následně zobrazit statistiky alespoň v následujícím rozsahu: 
    -	S kolika lidmi se průměrně zná každý uživatel sociální sítě?
    -	Kolik je v datasetu celkem uživatelů sociální sítě?
### Doplňkové zadání pro Senior developera
Vyberte si jednu z následujících úloh:
1.	Statistiky zobrazené pro dataset rozšiřte o následující:
    -	S kolika lidmi se průměrně uživatelé znají přes 1 uživatele, přes 2 uživatele atd. (až po maximální “vzdálenost” v importovaných datech)?
    -	Jak je průměrně veliká každá maximálně veliká skupina, kde se každý zná s každým? (Tedy pokud například uživatelé A, B, C a D se všichni vzájemně znají a uživatelé D, E, F se všichni vzájemně znají, ale mezi A , B , C a E, F není vzájemná vazba, pak jsou tyto skupiny dvě - A, B, C, D a skupina D, E, F, tedy výsledek je, že průměrná velikost je 3.5)
2.	Graficky zobrazte data pro dataset například v následující podobě (můžete využít libovolnou knihovnu, kterou v projektu použijete):
![image](https://github.com/Dice-Sensei/social-network-analyzer/assets/92362716/b7abed3e-a6e3-45d5-9a31-d3d44f3b358f)
### Na závěr…
Úloha bude vyhodnocena na základě těchto kritérií:
-	Dodržení funkčních požadavků
-	Kvalita napsaného kódu
-	Kvalita otestování (unit testy)

Pokud byste se rozhodl/a některé požadavky ze zadání nesplnit a nebo je splnit jen částečně, popište nám to, prosím, včetně zdůvodnění.

## Dev comments
- I will try to have this as monorepo for both parts (frontend, backend)
