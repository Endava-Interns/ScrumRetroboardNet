//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

<<<<<<< HEAD
namespace EndavaScrum.Models {
    using System;
    using System.Collections.Generic;

    public partial class Message {
=======
namespace EndavaScrum.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Message
    {
>>>>>>> master
        public int message_id { get; set; }
        public string text { get; set; }
        public int user_id { get; set; }
        public string category { get; set; }
<<<<<<< HEAD

=======
    
>>>>>>> master
        public virtual User User { get; set; }
    }
}
