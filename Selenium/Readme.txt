Pregledao tutorijale, budući da u zadatku kaze nesto jednostavno uzeo sam najlaksi pocetni primjer uz neka isprobavanja. 
Unutar programa se započinje predajom linka za Execute Automation Selenium Test Site stranicu. Dio stranice u koji unosimo podatke sastoji se od padajuceg izbornika, 3 textboxa, 2 radiobuttona i 2 checkboxa te button "Save". 
SeleniumSetMethods sadrzi 3 metode: Entertext za unos u texbox, Click za odabir i SelectDropDown za odabir na padajucem izborniku. SeleniumGetMethods sadrzi 2 metode: GetText za dohvacanje teksta iz textboxa i GetTextFromDrop za dohvacanje odabira iz izbornika. 
Atributi Setup, Test i TearDown. Unutar setupa napravljena je metoda initialize koja u pregledniku otvara predani URL i kao output daje "Opened URL". Unutar Test pomocu metoda iz SeleniumSetMethods pristupamo navedenim mjestima za unos i predajemo parametre (zadane za izbornik i štagod za texboxove) i odabir na radiobutton, checkbox i save button. U drugom dijelu pomoću SeleniumGetMethods metoda dohvaćamo upisane vrijednosti i u kombinaciji sa tekstom u outputu dobivamo tipa "Upisana vrijednost u Initial je: T.K." TearDown sadrži metodu CloseUp() koja zatvara preglednik i u output daje "Closing browser".
Verzija na Githubu je od jucer, u njoj jos pokusavam doci do vrijednosti sa radiobuttona i checkbox pa mi to bas nije jasno kako. Ovdje sam od GetText metode napravio GetTextButton metodu koja povlači "name" koji nema veze sa tim sta sam oznacio, a promijenio sam je sa value jer je value za english "male": 
              <input checked="checked" name="english" type="checkbox" value="male">
Što znaci da je vjv. netko kopirao liniju iz Gender buttona i nije ju izmjenio:
              <input checked="checked" name="Male" type="radio" value="male">
              
Što se tiće dojmova, sve je pregledno, lako shvatljivo i cini se šablonski.
Mislim da kad budem malo više radio da će biti više pitanja, trenutno je samo kako da pristupim odabranoj vrijednosti za radiobutton? 
Mislim da do odgovora mogu doći i sam, ako završim ranije sa druga dva zadatka vratit cu se na selenium, trenutno samo gledam da što prije dovršim zadnja dva zadatka jer sam 3 dana u zaostatku. 
