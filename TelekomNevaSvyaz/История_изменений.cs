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
    
    public partial class История_изменений
    {
        public int ID_истории { get; set; }
        public int ID_оборудования { get; set; }
        public string Кем_установлен { get; set; }
        public string Причина { get; set; }
        public int ID_места_установки { get; set; }
        public System.DateTime Дата { get; set; }
    
        public virtual Место_установки Место_установки { get; set; }
        public virtual Обрудование Обрудование { get; set; }
    }
}
