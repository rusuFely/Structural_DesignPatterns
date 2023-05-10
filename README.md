# Structural_DesignPatterns

# Modelul Adapter:
Ajută la transformarea interfeței unei clase într-o altă interfață în funcție de cerințele clientului. 
Deci, practic, oferind ceea ce este cerut de client prin utilizarea serviciului unei clase cu o interfață diferită. Modelul adaptorului este cunoscut 
și sub numele de Wrapper.

# Composite:
Clientul este capabil să opereze obiecte care pot reprezenta sau nu ierarhia acestuia. 
În termeni simpli, modelul compozit vă permite să creați un arbore ierarhic cu complexități unice, care permite tratarea fiecărui obiect individual.

# Decorator Pattern: 
Putem adăuga sau elimina funcționalitatea obiectului fără a modifica funcția sau aspectul exterior al obiectului. Prin urmare, 
cu ajutorul unui model de decorator, putem adăuga responsabilități suplimentare unui obiect fără a modifica funcționalitățile obiectului.

# Facade Pattern: 
Oferim o interfață simplificată unui set de interfețe ale unui subsistem pentru a ascunde complexitatea subsistemului de client. 
Cu cuvinte simple, cu ajutorul modelului de fațadă, facem subsistemele mai ușor de utilizat prin descrierea unei interfețe de nivel superior.

# Flyweight Patterns:  
Ne ajută să reutilizam tipuri similare de obiecte existente prin stocarea și crearea de noi obiecte atunci când obiecte similare nu sunt găsite.
Prin urmare, în termeni simpli, ne ajută să reducem costul mai multor instanțe care conțin aceleași date.

# Proxy Pattern: 
Oferim un substituent sau un obiect surogat pentru a controla accesul la obiectul original. În termeni simpli, furnizarea unui proxy sau un 
strat inactiv de informații înaintea clientului înainte de a accesa datele originale. 

# In acest proiect am utilizat trei design pattern-uri structurale: Adapter, Proxy și Composite.

Adapterul CsvDataAdapter facilitează accesul la datele dintr-un format diferit, adică un fișier CSV, în locul unei baze de date. Acest design pattern 
  permite utilizarea unei clase care să îndeplinească aceeași interfață ca și clasa dorită, dar care să folosească un alt format de date pentru a obține 
  informațiile necesare. În cadrul acestui proiect, adapterul CsvDataAdapter a fost utilizat pentru a citi datele despre cursuri dintr-un fișier CSV, în loc
  să fie citite dintr-o bază de date.
  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_DesignPatterns
{
    class CsvDataAdapter
    {
        private CsvFileReader _fileReader;

        public CsvDataAdapter(CsvFileReader fileReader)
        {
            _fileReader = fileReader;
        }

        public List<string[]> GetData()
        {
            return _fileReader.Read();
        }
    }

}

Proxy-ul CourseDataProxy a fost utilizat pentru a amâna încărcarea datelor până când acestea sunt efectiv necesare. În loc să încărce toate datele din
fișierul CSV în memorie la începutul programului, acestea sunt încărcate doar atunci când utilizatorul cere să le acceseze. Această abordare poate fi 
utilă atunci când datele sunt voluminoase și nu toate sunt necesare în același timp, economisind astfel resursele de sistem.

using LearningSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_DesignPatterns
{
    class CourseDataProxy : ICourseData
    {
        private CsvDataAdapter _dataAdapter;
        private List<string[]> _data;

        public CourseDataProxy(CsvDataAdapter dataAdapter)
        {
            _dataAdapter = dataAdapter;
        }

        public List<string[]> GetData()
        {
            if (_data == null)
            {
                Console.WriteLine("Loading course data...");
                _data = _dataAdapter.GetData();
            }

            return _data;
        }
    }
}

Composite-ul CourseComposite permite compunerea ierarhiei de cursuri din subcursuri și cursuri individuale. Acest design pattern permite gruparea 
obiectelor într-o structură ierarhică, astfel încât acestea să poată fi manipulate ca un întreg. În cadrul acestui proiect, composite-ul a fost 
utilizat pentru a crea o ierarhie de cursuri, astfel încât subcursurile și cursurile individuale să poată fi manipulate ca un întreg.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_DesignPatterns
{
    abstract class CourseComponent
    {
        protected string _name;

        public CourseComponent(string name)
        {
            _name = name;
        }

        public abstract void Display();
    }
}

Prin utilizarea acestor design pattern-uri, acest proiect oferă următoarele avantaje:

- Facilitatea de a accesa datele dintr-un format diferit, prin intermediul adapterului CsvDataAdapter.
- Economisirea resurselor de sistem prin amânarea încărcării datelor până când acestea sunt necesare, prin intermediul proxy-ului CourseDataProxy.
- Gruparea obiectelor într-o structură ierarhică, pentru a putea fi manipulate ca un întreg, prin intermediul composite-ului CourseComposite.

	Acest proiect ilustrează cum pot fi utilizate design pattern-urile Adapter, Proxy și Composite pentru a crea o ierarhie de obiecte. 
  Utilizarea unui adapter facilitează accesul la datele dintr-un format diferit, cum ar fi un fișier CSV în locul unei baze de date, iar utilizarea unui proxy 
  permite amânarea încărcării datelor până când acestea sunt efectiv necesare. Utilizarea unui composite permite compunerea obiectelor într-o ierarhie de
  obiecte, pentru a obține o structură ierarhică mai

În concluzie, utilizarea acestor design pattern-uri îmbunătățește modularitatea și flexibilitatea proiectului, permițând o mai bună separare a 
responsabilităților între clase și reducând acoplarea între ele. De asemenea, permite adaptarea mai ușoară a proiectului la schimbările viitoare și 
îmbunătățește performanța și eficiența utilizării resurselor de sistem.
