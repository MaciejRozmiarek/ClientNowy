---
Client komunikator (Win Forms) który wysyła do serwera zapytanie SQL np. Select do aplikacji Server która wykona zapytanie na bazie danych Mysql i wyśle do niego wynik.

---

Jak odpalić?

Projekt należy pobrać i skompilować np. Visual Studio

---

Jak przetestować?

---
Do prawidłowego działa potrzebny jest Serwer https://github.com/MaciejRozmiarek/SerwerTcpOkienkowy

- Po uruchomieniu aplikacji Client - należy ustawić adres IP oraz Port na którym Serwer oczekuje na połączenia.
-Należy również uzupełnić pole Query w którym podajemy nasze zapytanie Select.
- Wciskamy Run.
- Jeżeli zaytanie jest prawidłowe i tabela istnieje Serwer zwraca wynik Selecta. Dane są serializowane i client je deserializuje.
- Jeżeli zapytanie jest błędne Server zwróci nam błąd i zostanie wyświetlony w DataGridView.

