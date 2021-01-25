using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Repository
{
    /// <summary>
    /// Denne class har til formal at tilføre funktionalitet til de class'es der nedarver denne class.
    /// Den funktionalitet ClassNotify tilfører, er muligheden for at styre notifikationen af en hændelse i et Property.
    /// Dette opnåes ved at ClassNotify implementerer interfacet INotifyPropertyChanged.
    /// Dette interface sætter krav om at der skal oprettes event af typen PropertyChangedEventHandler.
    /// i metoden notify benyttes denne event til at afgøre om der er sket ændringer i den class som nedarver ClassNotify.
    /// Hvis der er sket ændringer benyttes PropertyChanged til at igangsætte en overgørelse af data fra et 
    /// givent Property til GUI hvor der er oprettet en Binding med et Id(Navnet på Property) der modsvarer navnet på det Propert der er 
    /// blevet opdateret med en ny værdi.
    /// </summary>
    public class ClassNotify : INotifyPropertyChanged
    { 
        public event PropertyChangedEventHandler PropertyChanged;
        public ClassNotify()
        {
        }
        protected void Notify(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
    


}
