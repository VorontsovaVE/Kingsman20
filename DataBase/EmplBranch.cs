//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kingsman20.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmplBranch
    {
        public int IDEmpBranch { get; set; }
        public int IdEmployeer { get; set; }
        public int IdBranch { get; set; }
    
        public virtual Branch Branch { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
