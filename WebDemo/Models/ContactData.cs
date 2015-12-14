using PerpetuumSoft.Knockout;
using System.Web.Script.Serialization;
using DelegateDecompiler;
using Newtonsoft.Json;

namespace WebDemo.Models
{
    public class ContactData
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Computed]
        [ScriptIgnore]
        [JsonIgnore]
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
    }
}