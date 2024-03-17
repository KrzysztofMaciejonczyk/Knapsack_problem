# Knapsack_problem
Autor: Krzysztof Maciejończyk

Opis programu:

Program służy do rozwiązywania problemu plecakowego. Został on podzielony na 3 części:

a) Program główny (LAB1), który działa w trybie aplikacji konsolowej,

b) Program dodatkowy (BackpackGUI), który działa w trybie okienkowym,

c) Testy jednostkowe (Backpack_testUnit).

Program główny został podzielony na 4 klasy:
- Backpack.cs - zawiera ona listę przedmiotów do posortowania według stosunku wartości do wagi oraz metodę Solve służącą rozwiązaniu problemu plecakowego. Końcowy wynik można wyświetlić, przeciążając metodę ToString.
- Item.cs - zawiera pola przedmiotu, takie jak jego waga, wartość, stosunek dwóch poprzednich pól oraz indeks. W celu ich korzystania utworzono funkcje typu get/set.
- Program.cs - główny program, który zajmuje się wczytaniem od użytkownika ilości przedmiotów, seedu oraz pojemności plecaka. Na końcu wyświetla listę spakowanych przedmiotów, całkowitą wagę oraz wartość.
- Result.cs - przechowuje informacje o przedmiotach, które zmieściły się w plecaku. Posaida również przeciążoną metodę ToString w celu przekształcenia wyników w stringa do łatwiejszej obsługi GUI.
- 
Do GUI zastosowano 3 pola tekstowe, w które użytkownik może wpisać liczbę przedmiotów, seed oraz pojemność plecaka. Po kliknięciu przycisku "Run" program wylicza ułożenie przedmiotów i wyświetla zarówno wszystkie dostępne przedmioty oraz wynik końcowy z przedmiotami, które się zmieściły oraz ich łączną wagę i wartość. Program został zabezpieczony w razie wpisania złych wartości w pola tekstowe.

Utworzono ponadto 8 testów jednostkowych badających najważniejsze funkcje programu.

Screeny działania programu zostały umieszczone w folderze Screenshots.
