//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TelekomNevaSvyaz
{
    using System;
    using System.Collections.Generic;
    
    public partial class Использование_портов
    {
        public int ID_использ_портов { get; set; }
        public int ID_порта { get; set; }
        public int ID_абонента { get; set; }
        public int Серийный_нормер { get; set; }
    
        public virtual Абонент Абонент { get; set; }
        public virtual Порт_оборудования Порт_оборудования { get; set; }
    }
}
